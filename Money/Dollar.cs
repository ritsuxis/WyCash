using System;

namespace Money
{
    public class Dollar : Money
    {
        

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int mutiplier)
        {
            return new Dollar(amount * mutiplier);
        }


        public override bool Equals(Object obj)
        {
            // Perform an equality check on two rectangles (Point object pairs).
            if (obj == null || GetType() != obj.GetType())
                return false;
            Dollar dollar = (Dollar)obj;
            return amount.Equals(dollar.amount);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
