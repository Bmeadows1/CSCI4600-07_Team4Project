using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
    class GasPlanet : Planet
    {
        class RockPlanet : Planet
        {
            private List<string> gasType;

            public List<string> GasType
            {
                get
                {
                    return gasType;
                }
                set
                {
                    gasType = value;
                }
            }
        }
    }
}
