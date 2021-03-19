using SolidDistribution.Core.Bag;
using SolidDistribution.Core.Grocery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidDistribution.Core.Storage.Multiple.BagStorage
{
    public abstract class BaseBagStorage<T> : BaseMultipleItemsStorage<T>, IBagStorage<T> where T : IBag<IGrocery>
    {
        public BaseBagStorage()
        {

        }
    }
}
