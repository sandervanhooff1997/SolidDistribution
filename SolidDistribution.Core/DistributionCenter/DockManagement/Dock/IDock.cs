using SolidDistribution.Core.DistributionCenter.DockManagement.Dock.DockStages;
using SolidDistribution.Core.Vehicle.DistributionVehicle;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.DistributionCenter.DockManagement.Dock
{
    /// <summary>
    /// A dock to load and unload groceries from vehicles
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDock<out T> : IDockStages where T : IDistributionVehicle
    {
        void Dock(IDistributionVehicle vehicle);
        
        bool IsAllowedToDock(IDistributionVehicle vehicle);

        IDistributionVehicle UnDock();

        bool IsAllowedToUnDock(IDistributionVehicle vehicle);

        IDistributionVehicle Vehicle { get; }
    }
}
