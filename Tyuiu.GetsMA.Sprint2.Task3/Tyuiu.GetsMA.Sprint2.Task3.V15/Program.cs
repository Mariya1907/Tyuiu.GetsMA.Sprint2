using System;
using Tyuiu.GetsMA.Sprint2.Task3.V15;
using Tyuiu.GetsMA.Sprint2.Task3.V15.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры  C#                           *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
        Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит      *");
        Console.WriteLine("* значение переменной X с клавиатуры.                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение переменной X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double res = ds.Calculate(x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Значение функции = " + res);
        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine(); 
    }
}
