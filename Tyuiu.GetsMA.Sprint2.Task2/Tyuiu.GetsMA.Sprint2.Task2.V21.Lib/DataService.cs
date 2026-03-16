using Tyuiu.Cources.Programming.Interfaces.Sprint2;  // ← TOЧНОЕ имя из вашего проекта!

namespace Tyuiu.GetsMA.Sprint2.Task2.V21.Lib
{
    public class DataService : ISprint2Task2V21
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((x == 3) && (y > 2) && (y < 8)) || ((x > 3) && (x <= 6) && (y >= 6) && (y <= 9)) || ((x >= 6) && (x <= 8) && (y >= 50) && (y <= 7)) || ((x >= 9) && (x <= 12) && (y >= 3) && (y <= 7)) || ((x >= 10) && (x <= 12) && (y >= 8) && (y <= 11)) || ((x >= 9) && (x <= 10) && (y >= 11) && (y <= 12)) || ((x == 13) && (y >= 6) && (y <= 8)))
            {
                res = true;

            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}