using SolidDistribution.Core.Bag;
using SolidDistribution.Core.Grocery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidDistribution.Core.Storage.BagStorage
{
    public abstract class BaseBagStorage<T> : IBagStorage<T> where T : IBag<IGrocery>
    {
        public BaseBagStorage()
        {

        }

        public IEnumerable<T> Bags { get; private set; }

        public bool IsFull => Count >= Maximum;

        public int Maximum { get; set; } = 3;

        public bool AllowedToAdd => Count < Maximum;

        public int Count => Bags.Count();

        public double Weight => Bags.Sum(x => x.Weight);

        public void Add(T bag)
        {
            var items = Bags.ToList();
            items.Add(bag);
            Bags = items;
        }
    }
}
