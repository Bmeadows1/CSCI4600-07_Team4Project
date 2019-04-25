using System;
using System.Linq;
using System.IO;

namespace CelestialSimulatorLibrary
{
    public class Star : CelestialObject
    {
        private const double STEFF_BOLTZ = 5.6703e-8;
        private double luminosity;
        private string starType;
        // Star Classification based off of temperature going from hottest to coolest.


        //Base Constructor which sets up the sun.
        public Star()
        {
            starType = "G2V";
            Temperature = Convert.ToDouble(GetTemp(starType));
            Color = GetRGB(starType).Split('.').Select(byte.Parse).ToList();
            Name = "Sun";
            Radius = 1;
            luminosity = Temperature * Temperature * Temperature * Temperature * Radius * Radius * STEFF_BOLTZ;
        }
        //Constructor that creates star based on classification using functions which access RGB values 
        //and Temperature from StarClassification.csv
        public Star(string classification)
        {
            starType = classification;
            Temperature = Convert.ToDouble(GetTemp(starType));
            Color = GetRGB(starType).Split('.').Select(byte.Parse).ToList();
            Name = "Sun";
            Radius = 1;
            luminosity = Temperature * Temperature * Temperature * Temperature * Radius * Radius * STEFF_BOLTZ;
        }
        //Gets temperature from StarClassification.csv using an input startype. Returns 0 if not found.
        public string GetTemp(string starType)
        {
            var strLines = File.ReadLines("StarClassification.csv");
            foreach (var line in strLines)
            {
                if (line.Split(',')[0].Equals(starType))
                {
                    return line.Split(',')[1];
                }
            }
            return "0";
        }
        //Gets RGB values from StarClassification.csv. Returns 00.00.00 if not found.
        public string GetRGB(string starType)
        {
            var strLines = File.ReadLines("StarClassification.csv");
            foreach (var line in strLines)
            {
                if (line.Split(',')[0].Equals(starType))
                {
                    return line.Split(',')[2];
                }
            }
            return "00.00.00";
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
