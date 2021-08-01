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
            Assert.IsTrue(Money.Money.MakeFranc(5).Equals(Money.Money.MakeFranc(5)));
            Assert.IsFalse(Money.Money.MakeFranc(5).Equals(Money.Money.MakeFranc(6)));
            Assert.IsFalse(Money.Money.MakeFranc(5).Equals(Money.Money.MakeDollar(5)));
        }

        [TestMethod]
        public void TestFrancMultiplication()
        {
            Money.Money five = Money.Money.MakeFranc(5);
            Assert.IsTrue(Money.Money.MakeFranc(10).Equals(five.Times(2)));
            Assert.IsTrue(Money.Money.MakeFranc(15).Equals(five.Times(3)));
        }

        [TestMethod]
        public void TestCurrency()
        {
           Assert.AreEqual("USD", Money.Money.MakeDollar(1).Currency());
           Assert.AreEqual("CHF", Money.Money.MakeFranc(1).Currency());
        }

        [TestMethod]
        public void TestDifferentClassEquality()
        {
            Assert.IsTrue(new Money.Money(10, "CHF").Equals(new Franc(10, "CHF")));
        }
    }
}
