using System;

namespace Money
{
    public class Dollar
    {
        public int amount;

        static void Main()
        {
            
        }
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public void Times(int mutiplier)
        {
            amount *= mutiplier;
        }


    }
}
