using SolidDistribution.Core.Bag;
using SolidDistribution.Core.Generic.Weight;
using System;

namespace SolidDistribution.Core.Grocery
{
    /// <summary>
    /// A grocery
    /// </summary>
    public interface IGrocery : IWeight
    {
        string Name { get; }
    }
}
