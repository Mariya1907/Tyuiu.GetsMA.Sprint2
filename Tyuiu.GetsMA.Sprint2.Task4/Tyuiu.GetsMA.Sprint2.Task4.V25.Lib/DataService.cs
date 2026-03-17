
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GetsMA.Sprint2.Task4.V25.Lib
{
    public class DataService : ISprint2Task4V25
    {
        public double Calculate(double x, double y)
        {
            double res = x - 20 * 2 < y / 4 ? (Math.Pow((1 + (2 / Math.Pow(x, 2))), y)) : (y + Math.Pow(((x + 1) / (y + 2)), x));
            return Math.Round(res, 3);
        }
    }
}