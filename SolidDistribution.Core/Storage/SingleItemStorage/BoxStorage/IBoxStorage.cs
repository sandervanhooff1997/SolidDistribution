using SolidDistribution.Core.Box;
using SolidDistribution.Core.Storage.Multiple;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Storage.SingleItem.BoxStorage
{
    /// <summary>
    /// A storage to store a box
    /// </summary>
    public interface IBoxStorage<out T> : IMultipleItemsStorage<T> where T : IBox
    {
    }
}
