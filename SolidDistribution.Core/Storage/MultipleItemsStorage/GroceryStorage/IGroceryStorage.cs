using SolidDistribution.Core.Box;
using SolidDistribution.Core.Generic.Count;
using SolidDistribution.Core.Grocery;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Storage.Multiple.GroceryStorage
{
    /// <summary>
    /// A storage to store groceries
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGroceryStorage<out T> : IMultipleItemsStorage<T>, ICount where T : IGrocery
    {

    }
}
