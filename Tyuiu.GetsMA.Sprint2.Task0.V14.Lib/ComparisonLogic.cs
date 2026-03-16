using System;
using tyuiu.cources.programming.interfaces.Sprint2;  // ✅ Sprint2!

namespace Tyuiu.GetsMA.Sprint2.Task0.V14.Lib
{
    public class ComparisonLogic : ISprint2Task0V14  // ✅ Найдётся!
    {
        
        public bool[] GetComparisonResults(int x, int y)  // ✅ Правильный метод!
        {
            bool[] results = new bool[6];
            results[0] = x > y;             // ✅ Логика правильная!
            results[1] = x < y;
            results[2] = (x - 321) >= y;
            results[3] = (x + 1000) < y;
            results[4] = x != y;
            results[5] = (y == 1000);
            return results;  // ✅ Массив 6 элементов!
        }
    }
}
