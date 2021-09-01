using System;

namespace test_ABNK
{
    public class CurrencyExchange //Валюта Обмена
    {
        private string iso = "null";
        private double exchangeRates = 0;


        public string Iso
        {
            get
            {
                return iso;
            }
            set
            {
                iso = value;
            }
        }
        
        public double ExchangeRates
        {
            get
            {
                return exchangeRates;
            }
            set
            {
                exchangeRates = value;
            }
        }

        



    }
}
