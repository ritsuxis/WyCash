﻿using System;

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

        public Dollar Times(int mutiplier)
        {
            return new Dollar(amount * mutiplier);
        }


    }
}
