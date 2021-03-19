using SolidDistribution.Core.Generic.Weight;
using SolidDistribution.Core.Grocery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidDistribution.Core.Storage.Multiple.GroceryStorage
{
    public abstract class BaseGroceryStorage<T> : BaseMultipleItemsStorage<T>, IGroceryStorage<T> where T : IGrocery
    {
        public BaseGroceryStorage()
        {

        }
    }
}
