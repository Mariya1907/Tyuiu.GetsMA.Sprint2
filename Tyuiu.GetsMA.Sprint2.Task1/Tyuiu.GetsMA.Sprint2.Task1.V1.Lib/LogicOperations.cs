namespace Tyuiu.GetsMA.Sprint2.Task1.V1.Lib
{
    // Реализация интерфейса ISprint2Task1V1
    public class LogicOperations : ISprint2Task1V1
    {
        public bool[] GetLogicResults(int a, int b, int c, int d)
        {
            bool[] results = new bool[6];

            // Последовательность операций сравнения, логики и арифметики
            results[0] = (a + 50 > b) || (c < d);      // True
            results[1] = (a > b) && (c > d);           // False
            results[2] = (a != c) ^ (b < d);           // True
            results[3] = !(a == b) & (c > d && false); // False
            results[4] = (a < d) && (b != c);          // True
            results[5] = (b + c < a) || (d == 0);      // False

            return results;
        }
    }
}

