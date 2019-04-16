using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
    class RockPlanet : Planet
    {
        private enum surfaceTypes
        {
            Frozen,
            Rock,
            OxygenatedRock
        }
        public RockPlanet() 
        {
            Radius = 1;
            Temperature = 210;
            Name = "Mars";

        }

       
    }
}
