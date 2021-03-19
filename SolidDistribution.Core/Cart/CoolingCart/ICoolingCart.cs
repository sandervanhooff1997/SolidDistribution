using SolidDistribution.Core.Box.BoxWithBag.Coolbox;
using SolidDistribution.Core.Storage.BoxStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Cart.CoolingCart
{
    /// <summary>
    /// A cart that stores only cooling boxes
    /// </summary>
    public interface ICoolingCart : ICart<IBoxStorage<ICoolBox>>
    {
    }
}
