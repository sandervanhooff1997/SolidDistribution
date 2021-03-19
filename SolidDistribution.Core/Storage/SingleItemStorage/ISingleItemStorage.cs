using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Storage.SingleItem
{
    public interface ISingleItemStorage<out T> : IStorage
    {
        T Item { get; }
    }
}
