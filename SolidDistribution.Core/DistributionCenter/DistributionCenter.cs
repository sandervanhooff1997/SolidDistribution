using SolidDistribution.Core.Cart.CoolingCart;
using SolidDistribution.Core.Cart.FreezerCart;
using SolidDistribution.Core.Cart.GenericCart;
using SolidDistribution.Core.Cart.RegularCart;
using SolidDistribution.Core.DistributionCenter.DockManagement;
using SolidDistribution.Core.Vehicle.DistributionVehicle;
using SolidDistribution.Core.Vehicle.DistributionVehicle.DeliveryCar;
using SolidDistribution.Core.Vehicle.DistributionVehicle.SupplierTruck;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.DistributionCenter
{
    public class DistributionCenter : IDistributionCenter
    {
        public DistributionCenter(
            string name, 
            IDockManagement dockManagement,
            IEnumerable<IDeliveryCar> deliveryCars,
            IEnumerable<ISupplierTruck> supplierTrucks,
            IEnumerable<IFreezerCart> freezerCarts,
            IEnumerable<ICoolingCart> coolingCarts,
            IEnumerable<IRegularCart> regularCarts,
            IEnumerable<IGenericCart> genericCarts)
        {
            Name = name;
            DeliveryCars = deliveryCars;
            SupplierTrucks = supplierTrucks;
            DockManagement = dockManagement;
            FreezerCarts = freezerCarts;
            CoolingCarts = coolingCarts;
            RegularCarts = regularCarts;
            GenericCarts = genericCarts;
        }

        public string Name { get; private set; }

        public IDockManagement DockManagement { get; private set; }

        public IEnumerable<IDeliveryCar> DeliveryCars { get; private set; }

        public IEnumerable<ISupplierTruck> SupplierTrucks { get; private set; }

        public IEnumerable<IFreezerCart> FreezerCarts { get; private set; }

        public IEnumerable<ICoolingCart> CoolingCarts { get; private set; }

        public IEnumerable<IRegularCart> RegularCarts { get; private set; }

        public IEnumerable<IGenericCart> GenericCarts { get; private set; }
    }
}
