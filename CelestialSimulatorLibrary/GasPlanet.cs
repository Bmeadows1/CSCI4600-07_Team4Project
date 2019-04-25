using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
   public class GasPlanet : CelestialObject
    {
            public enum gasType
            {
                Hydrogen,
                Helium,
                Nitrogen,
                Oxygen
            }
        //Sets up generic Gas planet when nothing is passed in.
        public GasPlanet()
        {
            Color = "216.217.200".Split('.').Select(Byte.Parse).ToList();
        }
        //Sets up Gas planet with gasType selected
        public GasPlanet(gasType gastype)
        {
            if(gastype == gasType.Helium)
            {
                Color = "216.217.200".Split('.').Select(Byte.Parse).ToList();
            }
            else if (gastype == gasType.Hydrogen)
            {
                Color = "255.255.255".Split('.').Select(Byte.Parse).ToList();
            }
            else if (gastype == gasType.Nitrogen)
            {
                Color = "143.143.255".Split('.').Select(Byte.Parse).ToList();
            }
            else if (gastype == gasType.Oxygen)
            {
                Color = "240.0.0".Split('.').Select(Byte.Parse).ToList();
            }
        }
    }
}
