using System;
using Tyuiu.GetsMA.Sprint2.Task1.V1.Lib;

namespace Tyuiu.GetsMA.Sprint2.Task1.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 119;
            int b = 196;
            int c = 134;
            int d = 327;

            ISprint2Task1V1 logic = new LogicOperations();

            bool[] results = logic.GetLogicResults(a, b, c, d);

            Console.WriteLine("Логическая последовательность:");
            foreach (var bResult in results)
            {
                Console.WriteLine(bResult);
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
