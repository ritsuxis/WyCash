using System;
using System.Collections.Generic;
using System.Text;

namespace Money
{
    abstract public class Money
    {
        protected int amount;
        protected String currency;
        abstract public Money Times(int multiplier);
        static void Main()
        {

        }

        public Money(int amount, String currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public String Currency()
        {
            return currency;
        }

        public bool EqualAmount(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && GetType().Equals(money.GetType());
        }

        public static Money MakeDollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money MakeFranc(int amount)
        {
            return new Franc(amount, "CHF");
        }

    }
}
