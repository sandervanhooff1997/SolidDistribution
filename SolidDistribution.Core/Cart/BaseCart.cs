using SolidDistribution.Core.Box;
using SolidDistribution.Core.Storage.Multiple;
using SolidDistribution.Core.Storage.SingleItem.BoxStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Cart
{
    public abstract class BaseCart<T> : BaseMultipleItemsStorage<T>, ICart<T> where T : IBoxStorage<IBox>
    {
        public BaseCart()
        {

        }
    }
}
