using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Vehicle
{
    /// <summary>
    /// A vehicle
    /// </summary>
    public interface IVehicle
    {
        void Drive();

        bool Driving { get; }
    }
}
