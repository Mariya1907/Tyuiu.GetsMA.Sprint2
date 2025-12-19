using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint2.Task3.V19.Lib;

namespace Tyuiu.GetsMA.Sprint2.Task3.V19.Test
{
    [TestClass]
    public sealed class ChessServiceTest
    {
        [TestMethod]
        public void TestBishopMove_True()
        {
            ChessService cs = new ChessService();
            Assert.IsTrue(cs.CanBishopMove(1, 1, 3, 3));
        }

        [TestMethod]
        public void TestBishopMove_False()
        {
            ChessService cs = new ChessService();
            Assert.IsFalse(cs.CanBishopMove(1, 1, 4, 3));
        }
    }
}
