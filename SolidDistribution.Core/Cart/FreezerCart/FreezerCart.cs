using SolidDistribution.Core.Box.BoxWithBag.FreezerBox;
using SolidDistribution.Core.Storage.SingleItem.BoxStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Cart.FreezerCart
{
    public abstract class FreezerCart : BaseCart<IBoxStorage<IFreezerBox>>
    {
        public FreezerCart()
        {

        }
    }
}
