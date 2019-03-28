using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
   public abstract class CelestialObjectBuilder
    {
        CelestialObject c;
        enum CelestialObjectTypes {Planet, RockPlanet, LiquidPlanet, GasPlanet, Star, NeutronStar, Magnetar, BlackHole };
        CelestialObjectBuilder(int CelestialObjectType)
        {
            if (CelestialObjectType == (int)CelestialObjectTypes.RockPlanet)
            {
                c = new RockPlanet();
            }
            else if (CelestialObjectType == (int)CelestialObjectTypes.LiquidPlanet)
            {
                c = new LiquidPlanet();
            }
            else if (CelestialObjectType == (int)CelestialObjectTypes.GasPlanet)
            {
                c = new GasPlanet();
            }
            else if (CelestialObjectType == (int)CelestialObjectTypes.Star)
            {
                c = new Star();
            }
            else if (CelestialObjectType == (int)CelestialObjectTypes.NeutronStar)
            {
                c = new NeutronStar();
            }
            else if (CelestialObjectType == (int)CelestialObjectTypes.Magnetar)
            {
                c = new Magnetar();
            }
            else if (CelestialObjectType == (int)CelestialObjectTypes.BlackHole)
            {
                c = new BlackHole();
            }
        }

    }
}
