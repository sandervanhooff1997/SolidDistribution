using SolidDistribution.Core.Box;
using SolidDistribution.Core.Storage.SingleItem.BoxStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidDistribution.Core.Storage.Multiple.CartStorage
{
    public abstract class BaseCartStorage<T> : BaseMultipleItemsStorage<T>, ICartStorage<T> where T : IBoxStorage<IBox>
    {
        public BaseCartStorage()
        {

        }
    }
}
