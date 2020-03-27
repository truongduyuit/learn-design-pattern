using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Design_Pattern
{
    public class Topping_EggPudding : MilkTeaTopping
    {
        public override double Cost()
        {
            Console.WriteLine("Egg pudding: " + Values.EGG_PUDDING_PRICE + "$");
            return Values.EGG_PUDDING_PRICE + base.Cost();
        }

        public Topping_EggPudding(IMilkTea milkTea) : base(milkTea)
        {
           
        }
    }
}
