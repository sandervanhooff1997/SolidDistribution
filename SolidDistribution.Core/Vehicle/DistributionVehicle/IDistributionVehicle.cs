using SolidDistribution.Core.Box;
using SolidDistribution.Core.Cart;
using SolidDistribution.Core.Cart.GenericCart;
using SolidDistribution.Core.DistributionCenter.DockManagement.Dock;
using SolidDistribution.Core.Generic.Maximum;
using SolidDistribution.Core.Generic.Weight;
using SolidDistribution.Core.Storage.Multiple.CartStorage;
using SolidDistribution.Core.Storage.SingleItem.BoxStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Vehicle.DistributionVehicle
{
    /// <summary>
    /// A vehicle used to distribute
    /// </summary>
    public interface IDistributionVehicle: IVehicle, IWeight, IMaximum
    {
        // A unique number that identifies this vehicle.
        int Id { get; set; }

        IEnumerable<ICart<IBoxStorage<IBox>>> Carts { get; }
    }
}
