using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Grocery
{
    public abstract class BaseGrocery : IGrocery
    {
        public BaseGrocery(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public string Name { get; private set; }

        public double Weight { get; private set; }
    }
}
