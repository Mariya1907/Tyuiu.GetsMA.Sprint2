
using Tyuiu.GetsMA.Sprint2.Task6.V13.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
       
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Получение результата из switch                                    *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
     
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами: g (год),*");
        Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным  определить дату   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите год ");
        int g = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите месяц ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите день ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.FindDateOfNextDay(g, m, n));

        Console.ReadKey();
    }
}