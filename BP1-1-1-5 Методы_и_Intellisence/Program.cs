using System;

namespace BP1_1_1_5_Методы_и_Intellisence
{
    class Program
    {


        public static void WriteNumber(int a)
        {
            Console.WriteLine("a is int");
            Console.WriteLine(a);
        }
        public static void WriteNumber(double a)
        {
            Console.WriteLine("a is double");
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            /*WriteNumber(2.4);*/
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello");
        }
    }
}
