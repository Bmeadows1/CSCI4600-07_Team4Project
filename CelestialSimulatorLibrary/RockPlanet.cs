using System.Linq;

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
        //Sets up generic rock planet.
        public RockPlanet()
        {
            Radius = 1;
            Temperature = 210;
            Name = "Mars";
            Color = "193.68.14".Split('.').Select(byte.Parse).ToList();
        }
        //Sets up rock planet with surfaceType chosen
        public RockPlanet(surfaceType surfacetype)
        {
            if(surfacetype == surfaceType.Frozen)
            {
                Color = "240.231.231".Split('.').Select(byte.Parse).ToList();
            }
            else if (surfacetype == surfaceType.Rock)
            {
                Color = "69.24.4".Split('.').Select(byte.Parse).ToList();
            }
            else if (surfacetype == surfaceType.OxygenatedRock)
            {
                Color = "193.68.14".Split('.').Select(byte.Parse).ToList();
            }
        }
    }
}
