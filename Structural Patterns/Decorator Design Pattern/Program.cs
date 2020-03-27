using System;

namespace Decorator_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var milkTea = new Topping_BlackSugar(new Topping_EggPudding(new Topping_FruitPudding(new MilkTea())));

            Console.WriteLine("Total: \t" + milkTea.Cost() + "$");
            Console.ReadKey();
        }
    }
}
