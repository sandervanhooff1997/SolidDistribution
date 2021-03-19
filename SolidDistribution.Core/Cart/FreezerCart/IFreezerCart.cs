using SolidDistribution.Core.Box.BoxWithBag.FreezerBox;
using SolidDistribution.Core.Storage.BoxStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Cart.FreezerCart
{
    /// <summary>
    /// A cart that stores only freezer boxes
    /// </summary>
    public interface IFreezerCart : ICart<IBoxStorage<IFreezerBox>>
    {

    }
}
