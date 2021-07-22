using System;
using System.Collections.Generic;
using System.Text;

namespace Money
{
    public class Franc
    {
        private int amount;

        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc Times(int mutiplier)
        {
            return new Franc(amount * mutiplier);
        }

        public bool EqualAmount(Object obj)
        {
            Franc dollar = (Franc)obj;
            return amount == dollar.amount;
        }

        public override bool Equals(Object obj)
        {
            // Perform an equality check on two rectangles (Point object pairs).
            if (obj == null || GetType() != obj.GetType())
                return false;
            Franc dollar = (Franc)obj;
            return amount.Equals(dollar.amount);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
