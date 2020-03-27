using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Design_Pattern
{
    public class Ticket
    {
        private string _name;
        private double _price;
        private IPromote _promote;

        public double GetPricePromote()
        {
            return _promote.ChargedDiscount(_price);
        }

        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
        public IPromote Promote { get => _promote; set => _promote = value; }
    }
}
