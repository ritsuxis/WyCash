using Microsoft.VisualStudio.TestTools.UnitTesting;
using Money;

namespace MoneyTest
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.Equals(10, five.amount);
        }
    }
}
