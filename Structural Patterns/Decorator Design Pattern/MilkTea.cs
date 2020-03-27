using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Design_Pattern
{
    public class MilkTea : IMilkTea
    {
        public double Cost()
        {
            Console.WriteLine("Milk tea: " + Values.MILKTEA_BASE_PRICE + "$");
            return Values.MILKTEA_BASE_PRICE;
        }
    }
}
