
using Tyuiu.GetsMA.Sprint2.Task7.V12.Lib;

namespace Tyuiu.GetsMA.Sprint2.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

           

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные          *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами *");
            Console.WriteLine("* X,Y в заштрихованной области.                                          *");
            Console.WriteLine("* Графики: y = x^2 и y = 2 - x                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите координату X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool result = ds.CheckDotInShadedArea(x, y);

            if (result)
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) не находится в заштрихованной области");
            }

            Console.ReadLine();
        }
    }
}