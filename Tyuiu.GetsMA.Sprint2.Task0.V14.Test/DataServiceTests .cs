using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.GetsMA.Sprint2.Task0.V14.Lib;

namespace Tyuiu.GetsMA.Sprint2.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1075;
            int y = 754;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
