using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Design_Pattern
{
    public class Promote_HalveDiscount : IPromote
    {
        public double ChargedDiscount(double price)
        {
            return price * 0.5d;
        }
    }
}
