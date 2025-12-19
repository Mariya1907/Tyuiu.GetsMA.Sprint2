using Tyuiu.Cources.Programming.Interfaces.Sprint2;

namespace Tyuiu.GetsMA.Sprint2.Task3.V19.Lib
{
    public class ChessService : ISprint2Task3V19
    {
        public bool CanBishopMove(int x1, int y1, int x2, int y2)
        {
            if (x1 < 1 || x1 > 8 || x2 < 1 || x2 > 8 ||
                y1 < 1 || y1 > 8 || y2 < 1 || y2 > 8)
            {
                return false;
            }

            return Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        }
    }
}
