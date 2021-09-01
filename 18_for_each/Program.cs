using System;

namespace _18_for_each
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Цикл 1 итерация: " + i);
                Console.WriteLine("");
                for (int j = 0; j <= 5; j++)
                {
                    Console.WriteLine("Цикл 2 итерация: " + j);
                }
                Console.WriteLine("");
            }
            double a = 12.5132;
            float b = (float)a;
        }
    }
}
