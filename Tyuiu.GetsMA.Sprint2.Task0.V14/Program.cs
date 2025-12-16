using System;
using Tyuiu.GetsMA.Sprint2.Task0.V14.Lib;

namespace Tyuiu.GetsMA.Sprint2.Task0.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1075;
            int y = 754;

            // Создаём объект через интерфейс
            ISprint2Task0V14 sprint = new ComparisonLogic();

            bool[] results = sprint.GetComparisonResults(x, y);

            Console.WriteLine("Логическая последовательность:");
            foreach (var b in results)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
