using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double expected = 5;
            double result = AlgoMethodB.Program.Sum(2, 3);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double expected = 0;
            double result = AlgoMethodB.Program.Substract(2, 2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double expected = 4;
            double result = AlgoMethodB.Program.Divide(12, 3);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            double expected = 6;
            double result = AlgoMethodB.Program.Multiply(2, 3);
            Assert.AreEqual(expected, result);
        }


    }
}
