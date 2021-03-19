using SolidDistribution.Core.Grocery.RegularBoxGrocery;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Grocery.RegularBagGrocery
{
    public class RegularBagGrocery : BaseGrocery, IRegularBoxGrocery
    {
        public RegularBagGrocery(string name, double weight) : base (name, weight)
        {

        }
    }
}
