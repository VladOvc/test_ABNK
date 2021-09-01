using System;

namespace BP1_1_1_6_Локальные_и_глобальные_переменные
{
    class Program
    {
        /*static int globalVariable;
        static int DoWork()
        {
            return 10;
        }*/


        static void m1()
        {
            int i = 0;
            {
                i = 1;
            }
        }
        static void Main(string[] args)
        {
            /*int localVariable = 0;
            Console.WriteLine(localVariable);
            localVariable = DoWork();
            Console.WriteLine(localVariable);*/
            
        }
    }
}
