using SolidDistribution.Core.Grocery;
using SolidDistribution.Core.Grocery.CoolBagGrocery;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Bag.CoolBag
{
    /// <summary>
    /// A cool bag to store cool bag groceries. 
    /// </summary>
    public interface ICoolBag : IBag<ICoolBagGrocery>
    {

    }
}
