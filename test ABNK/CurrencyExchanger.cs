using System;
using System.Collections.Generic;

namespace test_ABNK
{
    class CurrencyExchanger // Валютный Обменник, здесь работа с `Валютой Обмена` `добавление новых Валют Обмена` `конвертация валют`
    {
        public List<CurrencyExchange> currencyList;

        public CurrencyExchanger() // в конструктор класса производим инициализацию списка, и тут же добовляем два объекта
        {
            {
                currencyList = new List<CurrencyExchange>();
                currencyList.Add(new CurrencyExchange() { ExchangeRates = 26.71, Iso = "USD", });
                currencyList.Add(new CurrencyExchange() { ExchangeRates = 31.45, Iso = "EUR" });
            }
        }
        
        public void CurrencyExchangerConverter(int sourceCurrency, int destinationCurrency, double amountCurrency) // Конвертация Валют
        {
            double resum = (amountCurrency / currencyList[destinationCurrency].ExchangeRates) * currencyList[sourceCurrency].ExchangeRates;
            resum = Math.Round(resum, 4);
            Console.Write(currencyList[destinationCurrency].Iso + " " + resum);
        }

        public void AddCurrency(string iso, double exchangeRate) // Добавление валюты
        {
            currencyList.Add(new CurrencyExchange() { ExchangeRates = exchangeRate, Iso = iso, });
        }

        public void PrintCurrency() // Вывод на консоль весь список всех валют
        {
            for (int i = 0; i < currencyList.Count; i++)
            {
                PrintCurrency(i);
            }
        }

        public void PrintCurrencyNumbers() // Вывод на консоль весь список всех валют с нумерацией
        {
            for (int i = 0; i < currencyList.Count; i++)
            {
                int a = i + 1;
                Console.Write(a + ". ");
                PrintCurrency(i);
            }
        }

        public void PrintCurrency(int value) // Вывод на консоль валюты по индексу в списке
        {
            Console.WriteLine(currencyList[value].Iso + " " + currencyList[value].ExchangeRates);
        }

        
    }
}
