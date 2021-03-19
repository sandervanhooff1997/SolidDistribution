using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Grocery.CoolBagGrocery
{
    public class CoolBagGrocery : BaseGrocery, ICoolBagGrocery
    {
        public CoolBagGrocery(string name, double weight) : base (name, weight)
        {

        }
    }
}
