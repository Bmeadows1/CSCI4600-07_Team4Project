using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
   public class NeutronStar : Star
    {
        public NeutronStar()
        {
            Color = "255.255.255".Split('.').Select(Byte.Parse).ToList();
            Temperature = 600000;
        }
        }
    }

