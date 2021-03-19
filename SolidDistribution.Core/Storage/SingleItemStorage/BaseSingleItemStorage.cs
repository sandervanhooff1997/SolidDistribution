using SolidDistribution.Core.Generic.Weight;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Storage.SingleItem
{
    public abstract class BaseSingleItemStorage<T> : ISingleItemStorage<T> where T : IWeight
    {
        public BaseSingleItemStorage()
        {

        }

        public T Item { get; private set; }

        public bool IsFull => Item != null;

        public double Weight => Item.Weight;

        public int Maximum => 1;

        public bool AllowedToAdd => !IsFull;
    }
}
