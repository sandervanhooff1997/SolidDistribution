using SolidDistribution.Core.Cart;
using SolidDistribution.Core.Cart.CoolingCart;
using SolidDistribution.Core.Cart.FreezerCart;
using SolidDistribution.Core.Cart.GenericCart;
using SolidDistribution.Core.Cart.RegularCart;
using SolidDistribution.Core.DistributionCenter;
using SolidDistribution.Core.DistributionCenter.DockManagement;
using SolidDistribution.Core.DistributionCenter.DockManagement.Dock.DockForDeliveryCar;
using SolidDistribution.Core.DistributionCenter.DockManagement.Dock.DockForSupplierTruck;
using SolidDistribution.Core.Supplier.Suppliers;
using SolidDistribution.Core.Vehicle.DistributionVehicle.DeliveryCar;
using SolidDistribution.Core.Vehicle.DistributionVehicle.SupplierTruck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidDistribution.Console
{
    public static class DataSeeder
    {
        private static readonly int DOCK_FOR_DELEVERY_CAR_COUNT = 10;
        private static readonly int DOCK_FOR_SUPPLIER_TRUCK_COUNT = 3;
        private static readonly int CART_COUNT = 100;
        private static readonly int DELIVERY_CAR_COUNT = 100;
        private static readonly int SUPPLIER_TRUCK_COUNT = 10;

        private static readonly string DISTRIBUTION_CENTER_NAME = "AH Online";

        public static IDistributionCenter Seed()
        {
            var distributionCenter = new DistributionCenter(
                DISTRIBUTION_CENTER_NAME,
                SeedDockManagement(),
                SeedDeliveryCars(),
                SeedSupplierTrucks(),
                SeedFreezerCarts(),
                SeedCoolingCarts(),
                SeedRegularCarts(),
                SeedGenericCarts());

            return distributionCenter;
        }


        private static IDockManagement SeedDockManagement()
        {
            var dm = new DockManagement();

            for (var i = 0; i < DOCK_FOR_DELEVERY_CAR_COUNT; i++)
                dm.Add(new DockForDeliveryCar());

            for (var i = 0; i < DOCK_FOR_SUPPLIER_TRUCK_COUNT; i++)
                dm.Add(new DockForSupplierTruck());

            return dm;
        }
        private static IEnumerable<IDeliveryCar> SeedDeliveryCars()
        {
            var cars = new List<IDeliveryCar>();

            for (var i = 0; i < DELIVERY_CAR_COUNT; i++)
            {
                var car = new DeliveryCar();
                cars.Add(car);

            }

            return cars;
        }

        private static IEnumerable<ISupplierTruck> SeedSupplierTrucks()
        {
            var trucks = new List<ISupplierTruck>();

            for (var i = 0; i < SUPPLIER_TRUCK_COUNT; i++)
            {
                var supplier = (Suppliers)new Random().Next(0, 1);
                trucks.Add(new SupplierTruck(supplier));
            }

            return trucks;
        }

        private static IEnumerable<IFreezerCart> SeedFreezerCarts()
        {
            var cc = new List<IFreezerCart>();

            for (var i = 0; i < CART_COUNT; i++)
                cc.Add(new FreezerCart());

            return cc;
        }

        private static IEnumerable<ICoolingCart> SeedCoolingCarts()
        {
            var cc = new List<ICoolingCart>();

            for (var i = 0; i < CART_COUNT; i++)
                cc.Add(new CoolingCart());

            return cc;
        }
        private static IEnumerable<IRegularCart> SeedRegularCarts()
        {
            var cc = new List<IRegularCart>();

            for (var i = 0; i < CART_COUNT; i++)
                cc.Add(new RegularCart());

            return cc;
        }

        private static IEnumerable<IGenericCart> SeedGenericCarts()
        {
            var cc = new List<IGenericCart>();

            for (var i = 0; i < CART_COUNT; i++)
                cc.Add(new GenericCart());

            return cc;
        }

    }
}
