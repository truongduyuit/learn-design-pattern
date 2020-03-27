using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Design_Pattern
{
    public class Topping_BlackSugar : MilkTeaTopping
    {
        public override double Cost()
        {
            Console.WriteLine("Black sugar: " + Values.BLACK_SUGAR_PRICE + "$");
            return Values.BLACK_SUGAR_PRICE + base.Cost();
        }

        public Topping_BlackSugar(IMilkTea milkTea) : base(milkTea)
        {

        }

        public Topping_BlackSugar()
        {

        }
    }
}
