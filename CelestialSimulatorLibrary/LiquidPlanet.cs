using System.Linq;

namespace CelestialSimulatorLibrary
{
    public class LiquidPlanet : CelestialObject
    {
        public LiquidPlanet()
        {
            Color = "0.119.190".Split('.').Select(byte.Parse).ToList();
        }
    }
}
