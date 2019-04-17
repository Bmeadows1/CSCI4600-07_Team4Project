using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
    public class CelestialObjectBuilder
    {
        CelestialObject c;
        public enum CelestialObjectType
        {
            Planet,
            RockPlanet,
            LiquidPlanet,
            GasPlanet,
            Star,
            NeutronStar,
            Magnetar,
            BlackHole
        };

        //How can we pass different values in based off which type it is going to be? May need to rethink how this is set up.
        //Possibly have a generic type for each set up here, and when we have the type set, have a specific constructor for each CelestialObjectType

        public CelestialObjectBuilder(CelestialObjectType CelestialObjectType)
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
