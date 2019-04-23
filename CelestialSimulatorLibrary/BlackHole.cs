using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
   public class BlackHole : Star
    {
        public BlackHole()
        {
           
        }
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
