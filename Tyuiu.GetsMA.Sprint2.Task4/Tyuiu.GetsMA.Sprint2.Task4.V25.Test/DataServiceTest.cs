
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GetsMA.Sprint2.Task4.V25.Lib;

namespace Tyuiu.GetsMA.Sprint2.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 1.5;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = -200;
            double res = ds.Calculate(x, y);
            double wait = -199;
            Assert.AreEqual(wait, res);
        }
    }
}
