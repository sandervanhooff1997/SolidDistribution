using SolidDistribution.Core.Grocery;
using SolidDistribution.Core.Storage.GroceryStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidDistribution.Core.Bag
{
    public abstract class BaseBag<T> : BaseGroceryStorage<T>, IBag<T> where T : IGrocery
    {
        public override string ToString()
        {
            var sb = new StringBuilder();
            Type type = typeof(T);
            sb.Append($"\nA bag with {Count} {type.Name}:");

            Groceries.ToList().ForEach(g => sb.Append($"\n-{g.Name}"));

            return sb.ToString();
        }
    }
}
