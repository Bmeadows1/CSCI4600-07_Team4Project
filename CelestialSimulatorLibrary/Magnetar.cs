using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
    class Magnetar : NeutronStar
    {
        private double magenticFieldInstensity;

        public double MagenticFieldInstensity
        {
            get
            {
                return magenticFieldInstensity;
            }
            set
            {
                magenticFieldInstensity = value;
            }
        }
    }
}
