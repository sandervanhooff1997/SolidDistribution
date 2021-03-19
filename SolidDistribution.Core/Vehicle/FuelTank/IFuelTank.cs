using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Vehicle.FuelTank
{
    /// <summary>
    /// A fuel tank
    /// </summary>
    public interface IFuelTank
    {
        /// <summary>
        /// The fuel capacity in liters
        /// </summary>
        double FuelCapacity { get; }

        /// <summary>
        /// The current fuel in liters
        /// </summary>
        double CurrentFuel { get; set; }

        bool MustBeRefueled { get; }

        bool FuelTankEmpty { get; }
    }
}
