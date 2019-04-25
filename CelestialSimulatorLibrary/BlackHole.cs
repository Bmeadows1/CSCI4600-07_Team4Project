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
            Color = "0.0.0".Split('.').Select(Byte.Parse).ToList();
            Temperature = 0;
        }

    }
        }
