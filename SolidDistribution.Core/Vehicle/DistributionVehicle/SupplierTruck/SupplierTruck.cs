using SolidDistribution.Core.Supplier.Suppliers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Vehicle.DistributionVehicle.SupplierTruck
{
    public class SupplierTruck : BaseCombustionDistributionVehicle, ISupplierTruck
    {
        public SupplierTruck(Suppliers supplier) : base(200)
        {
            Supplier = supplier;
        }

        public Suppliers Supplier { get; private set; }
    }
}
