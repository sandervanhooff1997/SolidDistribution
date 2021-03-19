using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Grocery.FreezerBagGrocery
{
    public class FreezerBagGrocery : BaseGrocery, IFreezerBagGrocery
    {
        public FreezerBagGrocery(string name, double weight) : base (name, weight)
        {

        }
    }
}
