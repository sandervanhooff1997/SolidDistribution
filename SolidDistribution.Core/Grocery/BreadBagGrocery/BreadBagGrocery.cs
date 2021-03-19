using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Grocery.BreadBagGrocery
{
    public class BreadBagGrocery : BaseGrocery, IBreadBagGrocery
    {
        public BreadBagGrocery(string name, double weight) : base (name, weight)
        {

        }
    }
}
