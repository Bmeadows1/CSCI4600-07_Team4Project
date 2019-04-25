using System.Linq;

namespace CelestialSimulatorLibrary
{
    public class NeutronStar : Star
    {
        public NeutronStar()
        {
            Color = "255.255.255".Split('.').Select(byte.Parse).ToList();
            Temperature = 600000;
        }
    }
}

