using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GetsMA.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int year, int month, int day)
        {
            // ✅ ПРОВЕРКА ТОЛЬКО НЕККОРРЕКТНЫХ значений
            if (month < 1 || month > 12)
                throw new ArgumentException("Неверный месяц");

            if (day < 1)
                throw new ArgumentException("Неверный день");

            // ✅ Массив дней в месяце (високосный год)
            int[] daysInMonth = { 0, 31, IsLeapYear(year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day > daysInMonth[month])
                throw new ArgumentException("Неверный день месяца");

            // ✅ Вычисление следующей даты
            int nextDay = day + 1;
            int nextMonth = month;
            int nextYear = year;

            if (nextDay > daysInMonth[month])
            {
                nextDay = 1;
                nextMonth++;
                if (nextMonth > 12)
                {
                    nextMonth = 1;
                    nextYear++;
                }
            }

            // ✅ Формат YYYY-M-D (как в тестах)
            return $"{nextYear}-{nextMonth:D2}-{nextDay:D2}";
        }

        // ✅ Проверка високосного года
        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}

