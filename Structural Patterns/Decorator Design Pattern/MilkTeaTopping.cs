using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Design_Pattern
{
    public class MilkTeaTopping : IMilkTea
    {
        private IMilkTea _milkTea;

        public MilkTeaTopping(IMilkTea inner)
        {
            _milkTea = inner;
        }
          
        public virtual double Cost()
        {
            return _milkTea.Cost();
        }

        public MilkTeaTopping()
        {

        }
    }
}
