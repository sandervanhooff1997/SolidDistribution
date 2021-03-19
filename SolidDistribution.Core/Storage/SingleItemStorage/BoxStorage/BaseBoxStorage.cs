using SolidDistribution.Core.Box;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Storage.SingleItem.BoxStorage
{
    public abstract class BaseBoxStorage<T> : BaseSingleItemStorage<T>, IBoxStorage<T> where T : IBox
    {
        public BaseBoxStorage()
        {

        }
    }
}
