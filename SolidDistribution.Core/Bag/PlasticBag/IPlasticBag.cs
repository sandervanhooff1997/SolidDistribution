using SolidDistribution.Core.Grocery.PlasticBagGrocery;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Bag.PlasticBag
{
    /// <summary>
    /// A plastic bag to store plastic bag groceries.
    /// </summary>
    public interface IPlasticBag : IBag<IPlasticBagGrocery>
    {
    }
}
