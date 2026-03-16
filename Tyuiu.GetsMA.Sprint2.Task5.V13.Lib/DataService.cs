using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GetsMA.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int year, int month, int day)
        {
            // ✅ ВЫВОД ДЛЯ ОТЛАДКИ (временно)
            Console.WriteLine($"DEBUG: year={year}, month={month}, day={day}");

            if (month < 1 || month > 12)
                throw new ArgumentException("Неверный месяц");

            if (day < 1)
                throw new ArgumentException("Неверный день");

            int[] daysInMonth = { 0, 31, IsLeapYear(year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day > daysInMonth[month])
                throw new ArgumentException("Неверный день месяца");

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

            return $"{nextYear}-{nextMonth:D2}-{nextDay:D2}";
        }

        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}


