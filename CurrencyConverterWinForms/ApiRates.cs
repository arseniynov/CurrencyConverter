using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyConverterWinForms
{
    public class ApiRates
    {
        // Базовые курсы относительно USD для надежной оффлайн-работы
        private Dictionary<string, double> rates = new Dictionary<string, double>
        {
            { "USD", 1.0 },
            { "RUB", 82.75 },
            { "EUR", 0.89 }
        };

        public double GetRate(string currencyCode)
        {
            if (rates.ContainsKey(currencyCode))
                return rates[currencyCode];
            return 1.0;
        }
    }
}