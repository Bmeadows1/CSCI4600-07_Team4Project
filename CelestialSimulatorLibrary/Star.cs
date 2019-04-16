using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CelestialSimulatorLibrary
{
   class Star : CelestialObject
    {
        public const double STEFF_BOLTZ = 5.6703e-8;
        private double luminosity;
        string starType;
        // Star Classification based off of temperature going from hottest to coolest.

        
        //Base Constructor which sets up the sun.
        Star()
        {
            starType = "G2V";
            Temperature = Convert.ToDouble(GetTemp(starType));
            Color = GetRGB(starType);
            Name = "Sun";
            Radius = 1;

            luminosity = Temperature * Temperature * Temperature * Temperature * Radius * Radius * STEFF_BOLTZ;
        }

        String GetTemp(String starType)
        {
            var strLines = File.ReadLines("StarClassification.csv");
            foreach(var line in strLines)
            {
                if (line.Split(',')[1].Equals(starType))
                {
                    return line.Split(',')[2];
                }
            }
            return "";
        }

        String GetRGB(String starType)
        {
            var strLines = File.ReadLines("StarClassification.csv");
            foreach (var line in strLines)
            {
                if (line.Split(',')[1].Equals(starType))
                {
                    return line.Split(',')[3];
                }
            }
            return "";
        }

        // Luminosity is a calculation based off of Temperature and Radius. Determines an object's brightness.
        public double Luminosity
        {
            get
            {
                return luminosity;
            }
            set
            {
                luminosity = value;
            }
        }
    }
}
