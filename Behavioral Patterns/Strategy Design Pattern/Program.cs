using System;

namespace Strategy_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Random rd = new Random();

                var ticket = new Ticket();
                ticket.Price = 100;
                switch(rd.Next(0,3))
                {
                    case 0:
                        ticket.Name = "No discount ticket";
                        ticket.Promote = new Promote_NoDiscount();                      
                        break;
                    case 1:
                        ticket.Name = "Quarter discount ticket";
                        ticket.Promote = new Promote_QuarterDiscount();
                        break;
                    case 2:
                        ticket.Name = "Halve discount ticket";
                        ticket.Promote = new Promote_HalveDiscount();
                        break;
                }
                Console.WriteLine("========== " + i + " ==========");
                Console.WriteLine("Name: " + ticket.Name);
                Console.WriteLine("Price: " + ticket.Price);
                Console.WriteLine("Money have to pay: " + ticket.Price);

                // May change at runtime
            }

            Console.ReadKey();
        }
    }
}
