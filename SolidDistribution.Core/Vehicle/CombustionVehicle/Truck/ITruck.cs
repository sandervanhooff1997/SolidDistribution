using SolidDistribution.Core.Vehicle.DistributionVehicle;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Vehicle.CombustionVehicle.Truck
{
    /// <summary>
    /// A truck used to supply the distribution center with groceries
    /// </summary>
    public interface ITruck : ICombustionVehicle, IDistributionVehicle
    {
        
    }
}
