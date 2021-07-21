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
            Assert.IsTrue(new Dollar(10).Equals(five.Times(2)));
            Assert.IsTrue(new Dollar(15).Equals(five.Times(3)));
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(new Dollar(5).EqualAmount(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).EqualAmount(new Dollar(6)));
        }

        [TestMethod]
        public void TestFrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.IsTrue(new Franc(10).Equals(five.Times(2)));
            Assert.IsTrue(new Franc(15).Equals(five.Times(3)));
        }
    }
}
