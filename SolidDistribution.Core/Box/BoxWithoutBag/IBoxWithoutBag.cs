using SolidDistribution.Core.Grocery;
using SolidDistribution.Core.Storage.Multiple.GroceryStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Box.BoxWithoutBag
{
    public interface IBoxWithoutBag<out T> : IBox, IGroceryStorage<T> where T : IGrocery
    {

    }
}
