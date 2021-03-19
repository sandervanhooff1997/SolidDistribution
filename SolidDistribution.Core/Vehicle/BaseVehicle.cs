using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Vehicle
{
    public abstract class BaseVehicle : IVehicle
    {
        public BaseVehicle()
        {

        }

        public bool Driving { get; private set; }

        public void Drive()
        {
            Driving = true;
        }

        public void Stop()
        {
            Driving = false;
        }

        public abstract bool AllowedToDrive { get; }
    }
}
