using SolidDistribution.Core.Bag;
using SolidDistribution.Core.Generic.Count;
using SolidDistribution.Core.Grocery;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Storage.Multiple.BagStorage
{
    /// <summary>
    /// A storage to store a bag of groceries
    /// </summary>
    public interface IBagStorage<out T> : IMultipleItemsStorage<T>, ICount where T : IBag<IGrocery>
    {

    }
}
