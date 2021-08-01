using System;

namespace Money
{
    public class Dollar : Money
    {

        public Dollar(int amount, String currency) : base(amount, currency)
        {

        }

        public Money Times(int mutiplier)
        {
            return new Money(amount * mutiplier, currency);
        }
    }
}
