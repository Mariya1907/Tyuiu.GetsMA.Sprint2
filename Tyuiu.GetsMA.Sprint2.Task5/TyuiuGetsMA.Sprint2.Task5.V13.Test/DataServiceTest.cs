using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint2.Task5.V13.Lib;

namespace TyuiuGetsMA.Sprint2.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            // ✅ ТОЛЬКО КОРРЕКТНЫЕ ДАТЫ
            Assert.AreEqual("29.02.2024", ds.FindDateOfNextDay(2024, 2, 28));
            Assert.AreEqual("01.03.2024", ds.FindDateOfNextDay(2024, 2, 29));
            Assert.AreEqual("16.06.2024", ds.FindDateOfNextDay(2024, 6, 15));
            Assert.AreEqual("01.05.2024", ds.FindDateOfNextDay(2024, 4, 30));
            Assert.AreEqual("01.01.2025", ds.FindDateOfNextDay(2024, 12, 31));
        }
    }
}

