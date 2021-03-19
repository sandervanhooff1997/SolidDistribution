using SolidDistribution.Core.Generic.Color;
using SolidDistribution.Core.Grocery;
using SolidDistribution.Core.Storage.Multiple.GroceryStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidDistribution.Core.Box.BoxWithoutBag
{
    public abstract class BaseBoxWithoutBag<T> : BaseGroceryStorage<T>, IBoxWithoutBag<T> where T : IGrocery
    {
        public BaseBoxWithoutBag(Colors color) => Color = color;

        public Colors Color { get; private set; }
    }
}
