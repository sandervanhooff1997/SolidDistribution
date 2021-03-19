using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Grocery.PlasticBagGrocery
{
    public class PlastigBagGrocery : BaseGrocery, IPlasticBagGrocery
    {
        public PlastigBagGrocery(string name, double weight) : base (name, weight)
        {

        }
    }
}
