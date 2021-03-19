using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Grocery.NfcBagGrocery
{
    public class NfcBagGrocery : BaseGrocery, INfcBagGrocery
    {
        public NfcBagGrocery(string name, double weight) : base (name, weight)
        {

        }
    }
}
