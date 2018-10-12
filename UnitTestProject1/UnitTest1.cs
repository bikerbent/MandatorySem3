using Microsoft.VisualStudio.TestTools.UnitTesting;
using Components;

namespace ConversionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(28.34952, Converts.ConvertToGrams(1), 0.01); //Should test positively
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0.03527396195, Converts.ConvertToOunces(1), 0.01); //Should test positively
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1.03527396195, Converts.ConvertToOunces(1), 0.01); //Should test negatively
        }
    }
}
