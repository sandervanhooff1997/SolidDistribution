using SolidDistribution.Core.Grocery;
using SolidDistribution.Core.Storage.Multiple.GroceryStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Bag
{
    /// <summary>
    /// A bag storing groceries
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBag<out T> : IGroceryStorage<T> where T : IGrocery
    { 

    }
}
