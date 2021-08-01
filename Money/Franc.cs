using System;
using System.Collections.Generic;
using System.Text;

namespace Money
{
    public class Franc : Money
    {

        public Franc(int amount, String currency) : base(amount, currency)
        {

        }

        public Money Times(int mutiplier)
        {
            return new Money(amount * mutiplier, currency);
        }
    }
}
