using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CurrencyConverterWinForms
{
    public class Converter
    {
        private Storage storage;

        public Converter(Storage storage)
        {
            this.storage = storage;
        }

        public double Convert(double amount, double rateSource, double rateTarget)
        {
            if (amount <= 0 || rateSource <= 0 || rateTarget <= 0) return 0.0;

            double result = amount * (rateTarget / rateSource);
            return Math.Round(result, 2); // Округление до 2 знаков
        }

        public void SaveToHistory(string text)
        {
            storage.Save(text);
        }
    }
}