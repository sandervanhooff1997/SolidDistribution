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
        double Capacity { get; }

        double CurrentFuel { get; }

        bool MustBeRefueled { get; }
    }
}
