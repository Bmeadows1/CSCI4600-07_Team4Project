using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
    class LiquidPlanet : Planet
    {
        class RockPlanet : Planet
        {
            
            private double liquidLevel;

            

            public double LiquidLevel
            {
                get
                {
                    return liquidLevel;
                }
                set
                {
                    liquidLevel = value;
                }
            }
        }

    }
}
