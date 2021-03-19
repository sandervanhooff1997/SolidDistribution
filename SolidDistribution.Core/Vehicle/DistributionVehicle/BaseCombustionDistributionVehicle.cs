using SolidDistribution.Core.Vehicle.CombustionVehicle;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Vehicle.DistributionVehicle
{
    public class BaseCombustionDistributionVehicle : BaseVehicle, IDistributionVehicle, ICombustionVehicle
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
    }
}
