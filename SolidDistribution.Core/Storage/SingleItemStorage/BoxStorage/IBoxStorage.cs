using SolidDistribution.Core.Box;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Storage.SingleItem.BoxStorage
{
    /// <summary>
    /// A storage to store a box
    /// </summary>
    public interface IBoxStorage<out T> : ISingleItemStorage<T> where T : IBox
    {
    }
}
