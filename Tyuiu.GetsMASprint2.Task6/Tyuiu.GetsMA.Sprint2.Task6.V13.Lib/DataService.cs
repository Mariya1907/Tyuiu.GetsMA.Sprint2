using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GetsMA.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int nextG = g;
            int nextM = m;
            int nextN = n + 1;


            int daysInMonth;
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;

                case 2:
                    
                    bool leapYear = (g % 4 == 0 && g % 100 != 0) || (g % 400 == 0);
                    daysInMonth = leapYear ? 29 : 28;
                    break;

                default:
                    
                    daysInMonth = 30;  
                    break;
            }

            if (nextN > daysInMonth)
            {
                nextN = 1;
                nextM++;
                if (nextM > 12)
                {
                    nextM = 1;
                    nextG++;
                }
            }

            return $"{nextN:D2}.{nextM:D2}.{nextG}";
        }
    }
}
