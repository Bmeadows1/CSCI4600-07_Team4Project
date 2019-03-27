using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
    class NeutronStar : Star
    {
        private bool isSupernova;

        public bool IsSupernova
        {
            get
            {
                return isSupernova;
            }
            set
            {
                isSupernova = value;
            }
        }
    }
}
