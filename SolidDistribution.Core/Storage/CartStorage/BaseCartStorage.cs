using SolidDistribution.Core.Box;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Storage.CartStorage
{
    public abstract class BaseCartStorage<T> : ICartStorage<T> where T : IBox
    {
        public BaseCartStorage()
        {
            BoxPlaces = new List<T>();
        }

        public IEnumerable<T> BoxPlaces { get; private set; }

        public bool IsFull => 

        public double Weight => throw new NotImplementedException();

        public int Maximum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool AllowedToAdd => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();
    }
}
