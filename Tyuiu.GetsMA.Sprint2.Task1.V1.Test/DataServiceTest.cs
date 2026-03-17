
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GetsMA.Sprint2.Task1.V1.Lib;

namespace Tyuiu.GetsMA.Sprint2.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 119, b = 196, c = 134, d = 327;
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = { true, false, true, false, true, false };

            CollectionAssert.AreEqual(res, wait);
        }
    }
}
