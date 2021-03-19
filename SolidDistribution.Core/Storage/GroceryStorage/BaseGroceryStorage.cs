using SolidDistribution.Core.Grocery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidDistribution.Core.Storage.GroceryStorage
{
    public abstract class BaseGroceryStorage<T> : IGroceryStorage<T> where T : IGrocery
    {
        public BaseGroceryStorage()
        {
            Groceries = new List<T>();
        }

        public IEnumerable<T> Groceries { get; private set; }

        public bool IsFull => Count >= Maximum;

        public double Weight => Groceries.Sum(x => x.Weight);

        public int Maximum { get; set; } = 10;

        public int Count => Groceries.Count();

        public bool AllowedToAdd => Count < Maximum;

        public void Add(T grocery)
        {
            var items = Groceries.ToList();
            items.Add(grocery);
            Groceries = items;
        }
    }
}
