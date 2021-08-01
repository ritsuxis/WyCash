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

        public override Money Times(int mutiplier)
        {
            return new Franc(amount * mutiplier, "CHF");
        }

        public override bool Equals(Object obj)
        {
            // Perform an equality check on two rectangles (Point object pairs).
            if (obj == null || GetType() != obj.GetType())
                return false;
            Franc franc = (Franc)obj;
            return amount.Equals(franc.amount);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
