using SolidDistribution.Core.Bag;
using SolidDistribution.Core.Grocery;
using SolidDistribution.Core.Storage.BagStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Box.BoxWithBag
{
    public interface IBoxWithBag<T> : IBox, IBagStorage<T> where T : IBag<IGrocery>
    {

    }
}
