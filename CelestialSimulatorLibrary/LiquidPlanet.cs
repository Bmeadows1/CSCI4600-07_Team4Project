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
            private List<string> liquidType;
            private double liquidLevel;

            public List<string> LiquidType
            {
                get
                {
                    return liquidType;
                }
                set
                {
                    liquidType = value;
                }
            }

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
