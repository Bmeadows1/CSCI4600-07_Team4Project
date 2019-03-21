using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
    class Star : CelestialObject
    {
        private double luminosity;
        private List<string> hRDiagramClass; // Might change string

        public double Luminosity
        {
            get
            {
                return luminosity;
            }
            set
            {
                luminosity = value;
            }
        }
    }
}
