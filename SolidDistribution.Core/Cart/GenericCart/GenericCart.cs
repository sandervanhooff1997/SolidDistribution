using SolidDistribution.Core.Box;
using SolidDistribution.Core.Storage.SingleItem.BoxStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Cart.GenericCart
{
    public abstract class GenericCart : BaseCart<IBoxStorage<IBox>>
    {
        public GenericCart()
        {

        }
    }
}
