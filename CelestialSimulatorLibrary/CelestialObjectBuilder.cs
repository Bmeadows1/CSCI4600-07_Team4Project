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
        enum CelestialObjectTypes
        {   Planet,
            RockPlanet,
            LiquidPlanet,
            GasPlanet,
            Star,
            NeutronStar,
            Magnetar,
            BlackHole
        };

        CelestialObjectBuilder(CelestialObjectTypes CelestialObjectType)
        {
            if (CelestialObjectType == CelestialObjectTypes.RockPlanet)
            {
                c = new RockPlanet();
            }
            else if (CelestialObjectType == CelestialObjectTypes.LiquidPlanet)
            {
                c = new LiquidPlanet();
            }
            else if (CelestialObjectType == CelestialObjectTypes.GasPlanet)
            {
                c = new GasPlanet();
            }
            else if (CelestialObjectType == CelestialObjectTypes.Star)
            {
                c = new Star();
            }
            else if (CelestialObjectType == CelestialObjectTypes.NeutronStar)
            {
                c = new NeutronStar();
            }
            else if (CelestialObjectType == CelestialObjectTypes.Magnetar)
            {
                c = new Magnetar();
            }
            else if (CelestialObjectType == CelestialObjectTypes.BlackHole)
            {
                c = new BlackHole();
            }
        }

    }
}
