using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CurrencyConverterWinForms
{
    public class Storage
    {
        private string file = "history.txt";

        public void Save(string record)
        {
            try
            {
                File.AppendAllText(file, $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {record}\r\n");
        }
            catch { }
        }

        public string[] Load()
        {
            if (File.Exists(file))
                return File.ReadAllLines(file);
            return new string[0];
        }
    }
}