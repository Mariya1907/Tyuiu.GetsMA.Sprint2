using System;
using Tyuiu.GetsMA.Sprint2.Task5.V13.Lib;

namespace Tyuiu.GetsMA.Sprint2.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            // ИСПОЛЬЗУЕМ DataService вместо дублирования логики!
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                              *");
            Console.WriteLine("* Тема: Оператор switch                                                                                  *");
            Console.WriteLine("* Задание #5                                                                                             *");
            Console.WriteLine("* Вариант #13                                                                                            *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет                                       *");
            Console.WriteLine("* требуемое значение и возвращает результат.                                                             *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");

            Console.WriteLine("Введите значение года (g): ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение месяца (m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение дня (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            // ? ИСПОЛЬЗУЕМ ГОТОВЫЙ МЕТОД ИЗ DataService!
            string res = ds.FindDateOfNextDay(g, m, n);

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine($"Дата следующего дня: {res}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
