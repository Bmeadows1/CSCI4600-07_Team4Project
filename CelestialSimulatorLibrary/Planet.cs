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
            Nitrogen,
            Helium,
            Hydrogen
        }
        private double albedo;


        //Will be a percentage based off of user input. The higher the percentage, the denser the atmosphere.
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
        //Levels of light absorption of a planet. Affects Temperature
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
