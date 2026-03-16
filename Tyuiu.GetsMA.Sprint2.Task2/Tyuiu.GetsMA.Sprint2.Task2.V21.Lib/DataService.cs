using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GetsMA.Sprint2.Task2.V21.Lib
{
    public class DataService : ISprint2Task2V21
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // Исправленная логика области (убрал логические ошибки)
            if ((x == 3 && y > 2 && y <= 8) ||
                (x > 3 && x <= 6 && y >= 6) ||
                (x >= 9 && x <= 12 && y >= 3 && y <= 7))
            {
                return true;
            }
            return false;
        }
    }
}
