using SolidDistribution.Core.Box;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Storage.BoxStorage
{
    /// <summary>
    /// A storage to store a box
    /// </summary>
    public interface IBoxStorage<out T> : IStorage where T : IBox
    {
        T Box { get; }
    }
}
