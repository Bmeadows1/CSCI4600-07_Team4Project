using System.Linq;

namespace CelestialSimulatorLibrary
{
    public class BlackHole : Star
    {
        public BlackHole()
        {
            Color = "0.0.0".Split('.').Select(byte.Parse).ToList();
            Temperature = 0;
        }

    }
}
