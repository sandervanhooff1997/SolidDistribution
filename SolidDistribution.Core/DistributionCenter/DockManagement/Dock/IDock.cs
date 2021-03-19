using SolidDistribution.Core.DistributionCenter.DockManagement.Dock.DockStage;
using SolidDistribution.Core.Vehicle.DistributionVehicle;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SolidDistribution.Core.DistributionCenter.DockManagement.Dock
{
    /// <summary>
    /// A dock to load and unload groceries from vehicles
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDock<out T> : IDockStages where T : IDistributionVehicle
    {
        bool IsAllowedToDock { get; }

        T UnDock();

        bool IsAllowedToUnDock { get; }

        T Vehicle { get; }
    }
}
