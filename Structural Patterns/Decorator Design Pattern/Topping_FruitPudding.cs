using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Design_Pattern
{
    public class Topping_FruitPudding : MilkTeaTopping
    {
        public override double Cost()
        {
            Console.WriteLine("Fruit pudding: " + Values.FRUIT_PUDDING_PRICE + "$");
            return Values.FRUIT_PUDDING_PRICE + base.Cost();
        }

        public Topping_FruitPudding(IMilkTea milk) : base(milk)
        {

        }

        public Topping_FruitPudding()
        {

        }
    }
}
