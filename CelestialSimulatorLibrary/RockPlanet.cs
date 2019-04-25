using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
    public class RockPlanet : CelestialObject
    {
        public enum surfaceType
        {
            Frozen,
            Rock,
            OxygenatedRock
        }
        public RockPlanet()
        {
            Radius = 1;
            Temperature = 210;
            Name = "Mars";
            Color = "193.68.14".Split('.').Select(Byte.Parse).ToList();
        }
        public RockPlanet(surfaceType surfacetype)
        {
            if(surfacetype == surfaceType.Frozen)
            {
                Color = "240.231.231".Split('.').Select(Byte.Parse).ToList();
            }
            else if (surfacetype == surfaceType.Rock)
            {
                Color = "69.24.4".Split('.').Select(Byte.Parse).ToList();
            }
            else if (surfacetype == surfaceType.OxygenatedRock)
            {
                Color = "193.68.14".Split('.').Select(Byte.Parse).ToList();
            }
        }
    }
}
