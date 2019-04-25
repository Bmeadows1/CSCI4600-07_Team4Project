using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
   public class LiquidPlanet : CelestialObject
    {
        public LiquidPlanet()
        {
            Color = "0.119.190".Split('.').Select(Byte.Parse).ToList();
        }
        }
    }
