using SolidDistribution.Core.Box.BoxWithoutBag.RegularBox;
using SolidDistribution.Core.Storage.BoxStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Cart.RegularCart
{
    /// <summary>
    /// A cart that stores only regular boxes
    /// </summary>
    public interface IRegularCart : ICart<IBoxStorage<IRegularBox>>
    {
    }
}
