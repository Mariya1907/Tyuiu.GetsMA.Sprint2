
using Tyuiu.GetsMA.Sprint2.Task7.V12.Lib;

namespace Tyuiu.GetsMA.Sprint2.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            bool res1 = ds.CheckDotInShadedArea(0.5, 0.5);
            bool wait1 = true;
            Assert.AreEqual(wait1, res1);
        }
    }
}