using System;

namespace test_ABNK
{       
    class Program
    {
        static void Main()
        {
            Scenario Vodila = new Scenario();
            bool work = true;
            while (work)
            {
                Console.Clear();
                Console.WriteLine("Available currencies\n");
                Vodila.CurrencyExchanger.PrintCurrency();
                Console.WriteLine(
                    "\n1. Exchange currency" +
                    "\n2. Add new currency" +
                    "\n3. Exit"
                );

                Console.WriteLine("");
                ConsoleKey action = Console.ReadKey().Key;

                switch (action)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Vodila.CurrencyExchangeScenario();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Vodila.CurrencyAddingScenario();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        work = false;
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("\nError, you entered the wrong number! press ENTER to reboot ...");
                        Console.ReadLine();
                        break;
                }
            }
            
            

        }
    }
}
