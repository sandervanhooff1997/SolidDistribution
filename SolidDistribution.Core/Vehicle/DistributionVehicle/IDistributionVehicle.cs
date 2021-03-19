using SolidDistribution.Core.DistributionCenter.DockManagement.Dock;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Vehicle.DistributionVehicle
{
    /// <summary>
    /// A vehicle used to distribute
    /// </summary>
    public interface IDistributionVehicle: IVehicle
    {
        // A unique number that identifies this vehicle.
        int Id { get; set; }
    }
}
