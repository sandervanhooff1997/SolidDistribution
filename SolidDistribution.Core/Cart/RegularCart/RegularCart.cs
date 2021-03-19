using SolidDistribution.Core.Box.BoxWithoutBag.RegularBox;
using SolidDistribution.Core.Storage.SingleItem.BoxStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Cart.RegularCart
{
    public abstract class RegularCart : BaseCart<IBoxStorage<IRegularBox>>
    {
        public RegularCart()
        {

        }
    }
}
