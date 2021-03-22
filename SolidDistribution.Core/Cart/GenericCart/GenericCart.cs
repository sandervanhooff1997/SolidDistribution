using SolidDistribution.Core.Box;
using SolidDistribution.Core.Storage.SingleItem.BoxStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Cart.GenericCart
{
    public class GenericCart : BaseCart<IBoxStorage<IBox>>, IGenericCart
    {
        public GenericCart()
        {

        }
    }
}
