using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
    class BlackHole : Star
    {
        private double accretionDiskLvl;

        public double AccretionDiskLvl
        {
            get
            {
                return accretionDiskLvl;
            }
            set
            {
                accretionDiskLvl = value;
            }
        }
    }
}
