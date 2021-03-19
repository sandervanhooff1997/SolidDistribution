using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Generic.Count
{
    /// <summary>
    /// Has a count
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICount
    {
        int Count { get; }
    }
}
