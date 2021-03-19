using SolidDistribution.Core.Box;
using SolidDistribution.Core.Storage.BoxStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Cart.GenericCart
{
    /// <summary>
    /// A cart that stores all types of boxes
    /// </summary>
    public interface IGenericCart : ICart<IBoxStorage<IBox>>
    {
    }
}
