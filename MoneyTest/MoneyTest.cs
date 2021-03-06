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
            Money.Money five = Money.Money.MakeDollar(5);
            Assert.IsTrue(Money.Money.MakeDollar(10).Equals(five.Times(2)));
            Assert.IsTrue(Money.Money.MakeDollar(15).Equals(five.Times(3)));
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(Money.Money.MakeDollar(5).Equals(Money.Money.MakeDollar(5)));
            Assert.IsFalse(Money.Money.MakeDollar(5).Equals(Money.Money.MakeDollar(6)));
            Assert.IsFalse(Money.Money.MakeFranc(5).Equals(Money.Money.MakeDollar(5)));
        }

        [TestMethod]
        public void TestCurrency()
        {
           Assert.AreEqual("USD", Money.Money.MakeDollar(1).Currency());
           Assert.AreEqual("CHF", Money.Money.MakeFranc(1).Currency());
        }
    }
}
