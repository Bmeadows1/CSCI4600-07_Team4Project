using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
    class RockPlanet : Planet
    {
        private List<string> surfaceType;

        public List<string> SurfaceType
        {
            get
            {
                return surfaceType;
            }
            set
            {
                surfaceType = value;
            }
        }
    }
}
