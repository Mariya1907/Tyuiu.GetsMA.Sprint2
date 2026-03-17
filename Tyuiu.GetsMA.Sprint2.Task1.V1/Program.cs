using System;
using Tyuiu.GetsMA.Sprint2.Task1.V1.Lib;


namespace Tyuiu.GetsMA.Sprint2.Task1.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в         *");
            Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^, последовательность*");
            Console.WriteLine("* операций не должна нарушаться), а также арифметических выражений,       *");
            Console.WriteLine("* которая вернет логическую последовательность(массив):(True, False, True,*");
            Console.WriteLine("* False, True, False), при a = 119, b = 196, c = 134, d = 327             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* a = 119, b = 196, c = 134, d = 327                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int a = 119, b = 196, c = 134, d = 327;
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadLine();
        }
    }
}