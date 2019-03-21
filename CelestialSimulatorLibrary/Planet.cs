using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
    class Planet : CelestialObject
    {
        private double atmosphereDensity;
        private List<string> atmosphereType;
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

        public List<string> AtmosphereType
        {
            get
            {
                return atmosphereType;
            }
            set
            {
                atmosphereType = value;
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
