using SolidDistribution.Core.Bag;
using SolidDistribution.Core.Generic.Count;
using SolidDistribution.Core.Grocery;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Storage.BagStorage
{
    /// <summary>
    /// A storage to store a bag of groceries
    /// </summary>
    public interface IBagStorage<out T> : IStorage, ICount where T : IBag<IGrocery>
    {
        IEnumerable<T> Bags { get; }
    }
}
