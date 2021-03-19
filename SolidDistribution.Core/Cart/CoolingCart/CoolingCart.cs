using SolidDistribution.Core.Box.BoxWithBag.Coolbox;
using SolidDistribution.Core.Storage.SingleItem.BoxStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Cart.CoolingCart
{
    public abstract class CoolingCart : BaseCart<IBoxStorage<ICoolBox>>
    {
        public CoolingCart()
        {

        }
    }
}
