using System;
using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.GetsMA.Sprint2.Task0.V14.Lib;

namespace GetsMA.Sprint2.Task0.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 |Выполнил: Моторова Дана Дмитриевна | СМАРТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Операции сравнения.                                                *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #14                                                              *");
            Console.WriteLine("* Выполнил: Моторова Дана Дмитриевна | СМАРТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу из операций сравнений                                 *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) *");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую                    *");
            Console.WriteLine("* последовательность(массив):                                              *");
            Console.WriteLine("*                                                                          *");

            int x = 1075;
            int y = 754;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}

