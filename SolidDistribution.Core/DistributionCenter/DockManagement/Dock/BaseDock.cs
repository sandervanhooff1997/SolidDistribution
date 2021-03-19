using SolidDistribution.Core.DistributionCenter.DockManagement.Dock.DockStage;
using SolidDistribution.Core.Vehicle.DistributionVehicle;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SolidDistribution.Core.DistributionCenter.DockManagement.Dock
{
    public abstract class BaseDock<T> : IDock<T> where T : IDistributionVehicle
    {
        public BaseDock()
        {

        }

        public T Vehicle { get; private set; }

        public DockStages DockStage { get; set; }

        public bool IsEmpty => DockStage == DockStages.Empty;

        public bool IsDocking => DockStage == DockStages.Docked;

        public bool IsWaitingToUnDock => DockStage == DockStages.WaitingToUnDock;

        public bool IsUnDocking => DockStage == DockStages.Undocking;

        public async Task Dock(T vehicle)
        {
            if (!IsAllowedToDock) throw new Exception("Dock not empty.");

            Vehicle = vehicle;

            // Todo: change async behavior.
            await Task.Delay(new Random().Next(5000, 10000));
        }

        public bool IsAllowedToDock => IsEmpty;

        public bool IsAllowedToUnDock => IsWaitingToUnDock;

        public T UnDock()
        {
            if (IsEmpty) throw new Exception("The dock is empty.");
            if (!IsWaitingToUnDock) throw new Exception("Vehicle not ready to undock.");

            var v = Vehicle;
            Vehicle = default(T);

            return v;
        }
    }
}
