using System;
using System.Collections.Generic;
using System.Text;

namespace Money
{
    public class Money
    {
        protected int amount;
        protected String currency;
        public Money Times(int multiplier) {
            return new Money(amount * multiplier, currency);
        }
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

        public override String ToString()
        {
            return amount + " " + currency;
        }

        public static Money MakeDollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money MakeFranc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && Currency().Equals(money.Currency());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
