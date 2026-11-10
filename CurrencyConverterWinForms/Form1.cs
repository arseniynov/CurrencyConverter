using System;
using System.Windows.Forms;

namespace CurrencyConverterWinForms
{
    public partial class Form1 : Form
    {
        private Storage storage;
        private ApiRates api;
        private Converter converter;

        public Form1()
        {
            InitializeComponent();
            storage = new Storage();
            api = new ApiRates();
            converter = new Converter(storage);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] currencies = { "RUB", "USD", "EUR" };

            cmbFrom.Items.Clear();
            cmbTo.Items.Clear();
            cmbFrom.Items.AddRange(currencies);
            cmbTo.Items.AddRange(currencies);

            cmbFrom.SelectedIndex = 0; // RUB
            cmbTo.SelectedIndex = 1;   // USD

            UpdateHistoryList();
        }

        // Кнопка "Рассчитать"
        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка ввода суммы
            if (!double.TryParse(txtAmount.Text, out double amount) || amount <= 0)
            {
                MessageBox.Show("Введите корректную положительную сумму!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fromCurr = cmbFrom.SelectedItem?.ToString() ?? "RUB";
            string toCurr = cmbTo.SelectedItem?.ToString() ?? "USD";

            double rateFrom = api.GetRate(fromCurr);
            double rateTo = api.GetRate(toCurr);

            double result = converter.Convert(amount, rateFrom, rateTo);
            lblResult.Text = $"Результат: {result} {toCurr}";

            // Сохраняем в историю
            string record = $"{amount} {fromCurr} = {result} {toCurr}";
            converter.SaveToHistory(record);
            UpdateHistoryList();
        }

        // Смена валют местами
        private void button1_Click_1(object sender, EventArgs e)
        {
            int temp = cmbFrom.SelectedIndex;
            cmbFrom.SelectedIndex = cmbTo.SelectedIndex;
            cmbTo.SelectedIndex = temp;
        }

        private void UpdateHistoryList()
        {
            listHistory.Items.Clear();
            string[] records = storage.Load();
            foreach (var item in records)
            {
                listHistory.Items.Add(item);
            }
        }
    }
}