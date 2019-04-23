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
        public NeutronStar()
        {
            Color = "00.00.00".Split('.').Select(Byte.Parse).ToList();
            Temperature = 600000;
        }
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
