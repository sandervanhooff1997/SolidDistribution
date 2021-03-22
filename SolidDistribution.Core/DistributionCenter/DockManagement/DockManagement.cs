using SolidDistribution.Core.DistributionCenter.DockManagement.Dock;
using SolidDistribution.Core.Vehicle.DistributionVehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidDistribution.Core.DistributionCenter.DockManagement
{
    public class DockManagement : IDockManagement
    {
        public DockManagement()
        {
            Docks = new List<IDock<IDistributionVehicle>>();
        }

        public IEnumerable<IDock<IDistributionVehicle>> Docks { get; private set; }

        public int Count => Docks.Count();

        public void Add(IDock<IDistributionVehicle> dock)
        {
            var docks = Docks.ToList();
            docks.Add(dock);
            Docks = docks;
        }

        public IEnumerable<IDock<IDistributionVehicle>> GetDocks(Type dockType)
        {
            return Docks.Where(d => dockType == d.GetType());
        }
    }
}
