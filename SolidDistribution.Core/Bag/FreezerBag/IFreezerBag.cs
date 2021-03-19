using SolidDistribution.Core.Grocery.FreezerBagGrocery;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Bag.FreezerBag
{
    /// <summary>
    /// A freezer bag to store freezer bag groceries.
    /// </summary>
    public interface IFreezerBag : IBag<IFreezerBagGrocery>
    {
    }
}
