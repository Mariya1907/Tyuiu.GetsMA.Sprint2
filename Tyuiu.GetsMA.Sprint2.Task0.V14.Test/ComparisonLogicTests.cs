using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint2.Task0.V14.Lib;

namespace Tyuiu.GetsMA.Sprint2.Task0.V14.Test
{
    [TestClass]
    public class ComparisonLogicTests
    {
        [TestMethod]
        public void TestComparisonResults()
        {
            int x = 1075;
            int y = 754;
            bool[] expected = { true, false, true, false, true, false };

            ISprint2Task0V14 sprint = new ComparisonLogic();
            bool[] actual = sprint.GetComparisonResults(x, y);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
