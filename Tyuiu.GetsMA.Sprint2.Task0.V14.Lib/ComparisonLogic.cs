namespace Tyuiu.GetsMA.Sprint2.Task0.V14.Lib
{
    // Реализация интерфейса ISprint2Task0V14
    public class ComparisonLogic : ISprint2Task0V14
    {
        public bool[] GetComparisonResults(int x, int y)
        {
            bool[] results = new bool[6];

            // Последовательность операций сравнения и арифметики
            results[0] = x > y;             // true
            results[1] = x < y;             // false
            results[2] = (x - 321) >= y;    // true
            results[3] = (x + 1000) < y;    // false
            results[4] = x != y;            // true
            results[5] = (y == 1000);       // false

            return results;
        }
    }
}
