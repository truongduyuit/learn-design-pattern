using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Design_Pattern
{
    public class Promote_NoDiscount : IPromote
    {
        public double ChargedDiscount(double price)
        {
            return price;
        }
    }
}
