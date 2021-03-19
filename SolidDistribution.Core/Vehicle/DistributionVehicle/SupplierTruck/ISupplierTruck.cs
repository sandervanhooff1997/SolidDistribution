using SolidDistribution.Core.Supplier.Suppliers;
using SolidDistribution.Core.Vehicle.CombustionVehicle;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Vehicle.DistributionVehicle.SupplierTruck
{
    public interface ISupplierTruck : IDistributionVehicle, ICombustionVehicle
    {
        Suppliers Supplier { get; }
    }
}
