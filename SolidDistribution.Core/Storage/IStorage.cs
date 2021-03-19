using SolidDistribution.Core.Generic.Maximum;
using SolidDistribution.Core.Generic.Weight;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Storage
{
    /// <summary>
    /// A storage to store something
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStorage : IWeight, IMaximum
    {
        bool IsFull { get; }
    }
}