using SolidDistribution.Core.Box;
using SolidDistribution.Core.Generic.Count;
using SolidDistribution.Core.Storage.SingleItem.BoxStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Storage.Multiple.CartStorage
{
    /// <summary>
    /// A storage to store box storages
    /// </summary>
    public interface ICartStorage<out T> : IMultipleItemsStorage<T>, ICount where T : IBoxStorage<IBox>
    {

    }
}
