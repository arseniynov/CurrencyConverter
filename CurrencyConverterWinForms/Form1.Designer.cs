namespace CurrencyConverterWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAmount = new TextBox();
            cmbFrom = new ComboBox();
            cmbTo = new ComboBox();
            btnConvert = new Button();
            btnSwap = new Button();
            lblResult = new Label();
            listHistory = new ListBox();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(247, 74);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(92, 27);
            txtAmount.TabIndex = 0;
            // 
            // cmbFrom
            // 
            cmbFrom.FormattingEnabled = true;
            cmbFrom.Location = new Point(345, 54);
            cmbFrom.Name = "cmbFrom";
            cmbFrom.Size = new Size(114, 28);
            cmbFrom.TabIndex = 1;
            // 
            // cmbTo
            // 
            cmbTo.FormattingEnabled = true;
            cmbTo.Location = new Point(345, 93);
            cmbTo.Name = "cmbTo";
            cmbTo.Size = new Size(114, 28);
            cmbTo.TabIndex = 2;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(413, 127);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(126, 52);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Рассчитать";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += button1_Click;
            // 
            // btnSwap
            // 
            btnSwap.Location = new Point(269, 127);
            btnSwap.Name = "btnSwap";
            btnSwap.Size = new Size(126, 52);
            btnSwap.TabIndex = 4;
            btnSwap.Text = "<->";
            btnSwap.UseVisualStyleBackColor = true;
            btnSwap.Click += button1_Click_1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(465, 77);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(109, 20);
            lblResult.TabIndex = 5;
            lblResult.Text = "Результат: 0.00";
            // 
            // listHistory
            // 
            listHistory.FormattingEnabled = true;
            listHistory.Location = new Point(318, 185);
            listHistory.Name = "listHistory";
            listHistory.Size = new Size(171, 184);
            listHistory.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listHistory);
            Controls.Add(lblResult);
            Controls.Add(btnSwap);
            Controls.Add(btnConvert);
            Controls.Add(cmbTo);
            Controls.Add(cmbFrom);
            Controls.Add(txtAmount);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmount;
        private ComboBox cmbFrom;
        private ComboBox cmbTo;
        private Button btnConvert;
        private Button btnSwap;
        private Label lblResult;
        private ListBox listHistory;
    }
}
