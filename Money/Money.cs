using System;
using System.Collections.Generic;
using System.Text;

namespace Money
{
    public class Money
    {
        protected int amount;
        static void Main()
        {

        }

        public bool EqualAmount(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount;
        }


    }
}
