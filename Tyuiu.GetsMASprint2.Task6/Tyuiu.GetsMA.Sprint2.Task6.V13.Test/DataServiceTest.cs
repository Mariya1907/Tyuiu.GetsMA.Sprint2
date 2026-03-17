
using Tyuiu.GetsMA.Sprint2.Task6.V13.Lib;
namespace Tyuiu.GetsMA.Sprint2.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 2;
            int n = 28;
            string res = "2024.2.29";
            string wait = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);
        }
    }
}