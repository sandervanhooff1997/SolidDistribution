using SolidDistribution.Core.Box;
using SolidDistribution.Core.Storage.Multiple.CartStorage;
using SolidDistribution.Core.Storage.SingleItem.BoxStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Cart
{
    /// <summary>
    /// A cart that stores boxes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICart<out T> : ICartStorage<T> where T : IBoxStorage<IBox>
    {

    }
}
