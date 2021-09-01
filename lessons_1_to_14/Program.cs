using System;
using System.Globalization;

namespace test_ABNK
{
    class Program
    {
        public static bool GetCoolingStatus()
        {
            return true;
        }

        public static bool GetTemperature()
        {
            return true;
        }
        static void Main(string[] args)
        {

            if (GetTemperature() || GetCoolingStatus())
            {
                Console.WriteLine("Угроза повреждения кристала процессора!!!");
            }




            /*string str;
            int a, b;
            Console.WriteLine("Сумма двух чисел");
            Console.WriteLine("Первое число");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            Console.WriteLine("Второе число");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);
            Console.WriteLine("Сумма чисел " + (a + b));*/



            /*string str = "5df";
            
            try
            {
                int a = int.Parse(str);
                Console.WriteLine("Конвертация Успешная");
                Console.WriteLine(a);
            }
            catch (Exception)
            {
                Console.WriteLine("Не удалось сконвертировать в число --> " + str);
            }*/



            /*string str = "5";
            int a;
            bool result = int.TryParse(str, out a);
            if (result)
            {
                Console.WriteLine("Конвертация прошла успешно");
                Console.WriteLine("Ответ: " + a);
            }
            else
            {
                Console.WriteLine("Не удалось сконвертировать!!!");
            }*/


            /*int a = 40;
            int b = 60;
            int c = 10;
            double result = (double) a + b;
            Console.WriteLine("Среднее Арифметическое двух чисел a=" + a + " b=" + b + "   --->   " + (result / 2));
            Console.WriteLine("Сумма трёх чисел a=" + a + " b=" + b + " c=" + c + "   --->   " + (a + b + c));
            Console.WriteLine("Произведение трёх чисел a=" + a + " b=" + b + " c=" + c + "   --->   " + (a * b * c));*/


            /*int a = 2;
            int result = a++ * a;
            Console.WriteLine(result);*/


            /*int a = int.Parse(Console.ReadLine());
            if ((a % 2) == 0)
            {
                Console.WriteLine(a + " чётное ");
            }
            else
            {
                Console.WriteLine(a + " не чётное число");
            }*/

        }
    }
}
