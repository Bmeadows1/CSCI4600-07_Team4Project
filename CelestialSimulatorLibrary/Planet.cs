using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
    abstract class Planet : CelestialObject
    {
        private double atmosphereDensity;
        private enum atmosphereTypes
        {
            //TODO atmospheres 
        }
        private double albedo;

        public double AtmosphereDensity
        {
            get
            {
                return atmosphereDensity;
            }
            set
            {
                atmosphereDensity = value;
            }
        }

        public double Albedo
        {
            get
            {
                return albedo;
            }
            set
            {
                albedo = value;
            }
        }

    }
}
