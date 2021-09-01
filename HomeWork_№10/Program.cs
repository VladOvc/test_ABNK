using System;
using System.Globalization;

namespace test_ABNK
{
    class Program
    {

        public static void OutpuOnDisplay(char text, int value)
        {
            for (int i = 0; i < value; i++)
            {
                Console.Write(text);
            }
            Console.WriteLine("");
        }

        public static void Search(int[] numbers, int num)
        {
            bool areYouOk = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                
                if (numbers[i] == num)
                {
                    Console.WriteLine("Идекс массива: " + i);
                    areYouOk = true;
                }                
            }
            if (!areYouOk)
            {
                Console.WriteLine("К сожелению данной цифры мы не нашли в массиве данных(((");
            }
            Console.ReadLine();
            
        }

        static int[] GetRandomArray(uint length, int minValue, int maxValue)
        {
            int[] myArray = new int[length];

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue, maxValue);
            }

            return myArray;
        }

        static void Main()
        {
            /*Console.WriteLine("Введите один символов, который хотите отобразить несколько раз)");
            char text = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            Console.WriteLine("Сколько раз его отобразить?");
            int value = int.Parse(Console.ReadLine());
            OutpuOnDisplay(text, value);*/

            

            while (true)
            {
                Console.Clear();
                int[] numbers = GetRandomArray(10, -20, 10);
                int num;
                try
                {
                    Console.WriteLine("Какое число, вы хотите найти в массиве данных? И мы покажем точный индекс этого числа в массиве)) --> ");
                    Console.Write("{ ");

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        
                        Console.Write(Convert.ToString(numbers[i]) + ", ");
                        
                    }

                    Console.WriteLine(" }");
                    num = int.Parse(Console.ReadLine());                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Неудалось считать число, пожалуйста убедитесь что вы ввели число)");
                    Console.WriteLine("Нажмите `ENTER` для перезагрузки");
                    Console.ReadLine();
                    continue;
                }
                Search(numbers, num);
            }
            
            
            
            



        }
    }
}
