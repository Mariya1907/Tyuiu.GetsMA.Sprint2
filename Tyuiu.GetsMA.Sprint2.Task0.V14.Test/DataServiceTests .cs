using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.GetsMA.Sprint2.Task0.V14.Lib;

namespace Tyuiu.GetsMA.Sprint2.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTests  
    {
        [TestMethod]
        public void TestComparisonResults()
        {
            int x = 1075;
            int y = 754;
            bool[] expected = { true, false, true, false, true, false };

            ISprint2Task0V14 sprint = new DataService();
            bool[] actual = sprint.GetComparisonResults( x, y);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

}
