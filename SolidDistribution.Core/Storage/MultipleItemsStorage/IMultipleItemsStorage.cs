using SolidDistribution.Core.Generic.Weight;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Storage.Multiple
{
    public interface IMultipleItemsStorage<out T> : IStorage where T : IWeight
    {
        IEnumerable<T> Items { get; }
    }
}
