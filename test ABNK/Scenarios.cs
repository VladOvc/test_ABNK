using System;
using System.Globalization;


namespace test_ABNK
{
    class Scenarios
    {
        public CurrencyExchanger CurrencyExchanger = new CurrencyExchanger();

        public void CurrencyExchangeScenario()
        {
            Console.Clear();
            int sourceCurrency;
            int destinationCurrency;
            double amountCurrency;

            Console.WriteLine("Select your source currency\n");
            CurrencyExchanger.PrintCurrencyNumbers();

            Console.WriteLine("\nType appropriate digit to select currency");
            sourceCurrency = int.Parse(Console.ReadLine()) - 1;
            Console.Write("\nSource currency selected: ");
            CurrencyExchanger.PrintCurrency(sourceCurrency);

            Indentation();
            Console.WriteLine("\nSelect your destination currency\n");
            CurrencyExchanger.PrintCurrencyNumbers();

            Console.WriteLine("\nType appropriate digit to destination currency");
            destinationCurrency = int.Parse(Console.ReadLine()) - 1;
            Console.Write("\nDestination currency selected: ");
            CurrencyExchanger.PrintCurrency(destinationCurrency);

            Indentation();
            Console.WriteLine("enter your source currency Amount");
            amountCurrency = int.Parse(Console.ReadLine());

            Indentation();
            Console.Write("Finally you have ");
            CurrencyExchanger.CurrencyExchangerConverter(sourceCurrency, destinationCurrency, amountCurrency);


            ConsoleKey action = Console.ReadKey().Key;
            switch (action)
            {
                case ConsoleKey.Backspace:

                    break;                
                default:
                    break;
            }

        }

        public void CurrencyAddingScenario()
        {            
            string iso = "";
            double exchangeRate = 0;
            bool noError = true;
            bool noErrorKey = true;
            NumberFormatInfo NumberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            while (noError)
            {
                Console.Clear();
                Console.WriteLine("Enter currency Code");
                iso = Console.ReadLine().ToUpper();
                Console.WriteLine("Enter Exchange Rate");
                try
                {
                    exchangeRate = Convert.ToDouble(Console.ReadLine(), NumberFormatInfo);
                    break;
                }
                catch
                {
                    Console.WriteLine("Conversion error, press Enter to reboot");
                    Console.ReadLine();
                }
            }

            CurrencyExchanger.AddCurrency(iso, exchangeRate);

            while (noErrorKey)
            {
                Console.WriteLine("Press Backspace to back to the main menu");
                ConsoleKey action = Console.ReadKey().Key;

                switch (action)
                {
                    case ConsoleKey.Backspace:
                        noErrorKey = false;
                        break;
                    default:
                        Console.WriteLine(action.ToString());
                        break;
                }
            }
        }

        private void Indentation()
        {
            Indentation(50);
        }
        private void Indentation(int length)
        {
            Console.WriteLine("");
            for (int i = 0; i < length; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
        }

    }
}
