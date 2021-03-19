using SolidDistribution.Core.Box;
using SolidDistribution.Core.Generic.Count;
using SolidDistribution.Core.Grocery;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Storage.GroceryStorage
{
    /// <summary>
    /// A storage to store groceries
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGroceryStorage<out T> : IStorage, ICount where T : IGrocery
    {
        IEnumerable<T> Groceries { get; }
    }
}
