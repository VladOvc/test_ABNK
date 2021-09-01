using System;

namespace Switch
{
    class Program
    {
        /*
        Два варианта калькулятора, который должен выполнять простые действия (Умножение, вычитание...), для конструкции if else, и второй варинат для switch
        */

        static void Main(string[] args)
        {
            /* int a = int.Parse(Console.ReadLine());

             switch (a)
             {
                 case 1:
                     Console.WriteLine("Вы ввели чило " + a);
                     break;
                 case 2:
                     Console.WriteLine("Вы ввели чило " + a);
                     break;
                 default:
                     Console.WriteLine("Что делать с этим числом?");
                     break;
             }*/

            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;

                try
                {
                    Console.WriteLine("Введите первое число:");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не удалось преобразить строку в число!");
                    Console.ReadLine();
                    continue;
                }                            

                Console.WriteLine("что вы хотите сделать? Сумировать? Поделить? Умножение?  (+ - * /):");
                action = Console.ReadLine();                

                switch (action)
                {
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        if (secondValue == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine(firstValue / secondValue);
                        }                        
                        break;
                    default:
                        Console.WriteLine("Ошибка! Вы выбрали не верную операцию!");
                        break;
                }
                Console.ReadLine();
            }
            



            /*if (action == "+")
            {
                Console.WriteLine(firstValue + secondValue);
            }
            else
            {
                if (action == "-")
                {
                    Console.WriteLine(firstValue - secondValue);
                }
                else
                {
                    if (action == "*")
                    {
                        Console.WriteLine(firstValue * secondValue);
                    }
                    else
                    {
                        if (action == "/")
                        {
                            Console.WriteLine(firstValue / secondValue);
                        }
                        else
                        {
                            Console.WriteLine("Ошибка! Вы выбрали неверную операцию!");
                        }
                    }
                }
            }*/


        }
    }
}
