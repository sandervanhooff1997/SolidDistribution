using SolidDistribution.Core.Box;
using SolidDistribution.Core.Generic.Count;
using SolidDistribution.Core.Storage.BoxStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Storage.CartStorage
{
    /// <summary>
    /// A storage to store box storages
    /// </summary>
    public interface ICartStorage<out T> : IStorage<T>, ICount where T : IBoxStorage<IBox>
    {
        //IEnumerable<T> BoxPlaces { get; }
    }
}
