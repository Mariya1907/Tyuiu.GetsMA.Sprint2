
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GetsMA.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            bool leftArea = (y >= 0) && (y <= 2 - x) && (y <= x * x);

            bool rightArea = (y < x * x) && (y >= 2 - x);

            return leftArea || rightArea;

        }
    }
}
