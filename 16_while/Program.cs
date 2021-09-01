using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_while
{
    class Program
    {
        /*
        Подсчитывать сумму и колисечтво чётных и нечётных целых чисел в том диапозоне который укажет пользователь
        */

        static void Main(string[] args)
        {
            uint evenNumberCount = 0;
            uint oddNumberCount = 0;
            int evenNumberSum = 0;
            int oddNumberSum = 0;

            Console.WriteLine("Введите превое число диапозона: ");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число диапозона: ");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue++ < limit)
            {

                if (currentValue % 2 == 0)
                {
                    evenNumberCount++;
                    evenNumberSum += currentValue;
                }
                else
                {
                    oddNumberCount++;
                    oddNumberSum += currentValue;
                }
            }

            Console.WriteLine("Количество чётных чисел: " + evenNumberCount);
            Console.WriteLine("Количество нечётных чисел: " + oddNumberCount);
            Console.WriteLine("Сумма чётных чисел: " + evenNumberSum);
            Console.WriteLine("Сумма нечётных чисел: " + oddNumberSum);
            Console.ReadLine();
        }
    }
}
