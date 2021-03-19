using SolidDistribution.Core.Generic.Weight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidDistribution.Core.Storage.Multiple
{
    public abstract class BaseMultipleItemsStorage<T> : IMultipleItemsStorage<T> where T : IWeight
    {
        public BaseMultipleItemsStorage()
        {
            Items = new List<T>();
        }

        public IEnumerable<T> Items { get; private set; }

        public bool IsFull => Count >= Maximum;

        public double Weight => Items.Sum(x => x.Weight);

        public int Maximum { get; set; } = 10;

        public int Count => Items.Count();

        public bool AllowedToAdd => !IsFull;

        public void Add(T item)
        {
            var items = Items.ToList();
            items.Add(item);
            Items = items;
        }
    }
}
