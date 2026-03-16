using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GetsMA.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            if (m < 1 || m > 12)
                return "Введено неверное значение";

            if (n < 1)
                return "Введено неверное значение";

            int daysInMonth;
            switch (m)
            {
                case 2: daysInMonth = 29; break;
                case 4: case 6: case 9: case 11: daysInMonth = 30; break;
                default: daysInMonth = 31; break;
            }

            if (n > daysInMonth)
                return "Введено неверное значение";

            int next_g = g;
            int next_m = m;
            int next_n = n + 1;

            if (next_n > daysInMonth)
            {
                next_n = 1;
                next_m++;
                if (next_m > 12)
                {
                    next_m = 1;
                    next_g++;
                }
            }

            // ✅ ФОРМАТ YYYY-M-D для тестов!
            return $"{next_g}-{next_m:D2}-{next_n:D2}";
        }
    }
}
