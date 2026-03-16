using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GetsMA.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int year, int month, int day)
        {
            // ✅ УБРАЛИ DEBUG и throw - ТОЛЬКО return строк!

            if (month < 1 || month > 12)
                return "Введено неверное значение";

            if (day < 1)
                return "Введено неверное значение";

            // ✅ Правильная проверка високосного года
            int daysInFeb = IsLeapYear(year) ? 29 : 28;
            int daysInMonth;

            switch (month)
            {
                case 2: daysInMonth = daysInFeb; break;
                case 4: case 6: case 9: case 11: daysInMonth = 30; break;
                default: daysInMonth = 31; break;
            }

            if (day > daysInMonth)
                return "Введено неверное значение";

            // Вычисление следующей даты
            int nextDay = day + 1;
            int nextMonth = month;
            int nextYear = year;

            if (nextDay > daysInMonth)
            {
                nextDay = 1;
                nextMonth++;
                if (nextMonth > 12)
                {
                    nextMonth = 1;
                    nextYear++;
                }
            }

            // ✅ Формат ДД.ММ.ГГГГ для консоли
            return $"{nextDay:D2}.{nextMonth:D2}.{nextYear}";
        }

        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}


