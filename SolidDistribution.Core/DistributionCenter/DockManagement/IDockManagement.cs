using SolidDistribution.Core.DistributionCenter.DockManagement.Dock;
using SolidDistribution.Core.Generic.Count;
using SolidDistribution.Core.Vehicle.DistributionVehicle;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.DistributionCenter.DockManagement
{
    /// <summary>
    /// Managing docks in a distribution center
    /// </summary>
    public interface IDockManagement : ICount
    {
        IEnumerable<IDock<IDistributionVehicle>> Docks { get; }

        IEnumerable<IDock<IDistributionVehicle>> GetDocks(Type dock);
    }
}
