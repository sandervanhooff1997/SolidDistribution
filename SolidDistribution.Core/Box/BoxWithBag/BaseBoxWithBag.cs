using SolidDistribution.Core.Bag;
using SolidDistribution.Core.Generic.Color;
using SolidDistribution.Core.Grocery;
using SolidDistribution.Core.Storage.BagStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidDistribution.Core.Box.BoxWithBag
{
    public abstract class BaseBoxWithBag<T> : BaseBagStorage<T>, IBoxWithBag<T> where T : IBag<IGrocery>
    {
        public BaseBoxWithBag(Colors color) => Color = color;

        public Colors Color { get; private set; }
    }
}
