using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Grocery.PlasticBagGrocery
{
    public class PlasticBagGrocery : BaseGrocery, IPlasticBagGrocery
    {
        public PlasticBagGrocery(string name, double weight) : base (name, weight)
        {

        }
    }
}
