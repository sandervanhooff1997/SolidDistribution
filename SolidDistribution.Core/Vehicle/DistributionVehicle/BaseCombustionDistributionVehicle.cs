using SolidDistribution.Core.Box;
using SolidDistribution.Core.Cart;
using SolidDistribution.Core.Cart.GenericCart;
using SolidDistribution.Core.Storage.Multiple;
using SolidDistribution.Core.Storage.Multiple.CartStorage;
using SolidDistribution.Core.Storage.SingleItem.BoxStorage;
using SolidDistribution.Core.Vehicle.CombustionVehicle;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidDistribution.Core.Vehicle.DistributionVehicle
{
    public abstract class BaseCombustionDistributionVehicle : BaseVehicle, IDistributionVehicle, ICombustionVehicle
    {
        public BaseCombustionDistributionVehicle(double fuelCapacity)
        {
            FuelCapacity = fuelCapacity;
            // New vehicles start with a full tank.
            CurrentFuel = fuelCapacity;
        }

        public int Id { get; set; }

        public double FuelCapacity { get; private set; }

        public double CurrentFuel { get; set; }

        // Refuel if lower than 30% fuel.
        public bool MustBeRefueled => (CurrentFuel / FuelCapacity) * 100 < 30;

        public bool FuelTankEmpty => CurrentFuel <= 0;

        // TODO: Maybe add extra rules here in the future?
        public override bool AllowedToDrive => !FuelTankEmpty;

        public IEnumerable<ICart<IBoxStorage<IBox>>> Carts { get; private set; }

        public double Weight => Carts.Sum(c => c.Weight);

        public abstract int Maximum { get; }

        public abstract bool AllowedToAdd { get; }
    }
}
