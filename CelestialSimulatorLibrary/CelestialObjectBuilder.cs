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
        enum CelestialObjectType
        {   Planet,
            RockPlanet,
            LiquidPlanet,
            GasPlanet,
            Star,
            NeutronStar,
            Magnetar,
            BlackHole
        };

        CelestialObjectBuilder(CelestialObjectType CelestialObjectType)
        {
            if (CelestialObjectType == CelestialObjectType.RockPlanet)
            {
                c = new RockPlanet();
            }
            else if (CelestialObjectType == CelestialObjectType.LiquidPlanet)
            {
                c = new LiquidPlanet();
            }
            else if (CelestialObjectType == CelestialObjectType.GasPlanet)
            {
                c = new GasPlanet();
            }
            else if (CelestialObjectType == CelestialObjectType.Star)
            {
                c = new Star();
            }
            else if (CelestialObjectType == CelestialObjectType.NeutronStar)
            {
                c = new NeutronStar();
            }
            else if (CelestialObjectType == CelestialObjectType.Magnetar)
            {
                c = new Magnetar();
            }
            else if (CelestialObjectType == CelestialObjectType.BlackHole)
            {
                c = new BlackHole();
            }
        }

    }
}
