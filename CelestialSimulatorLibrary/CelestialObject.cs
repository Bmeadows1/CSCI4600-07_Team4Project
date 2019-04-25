using System.Collections.Generic;

namespace CelestialSimulatorLibrary
{
    public abstract class CelestialObject
    {
        private string name;
        private double radius;
        private double temperature;
        private List<byte> color;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        //Distance from center of object to surface
        //Will be in terms of Solar Radii (1 = 1 radius of the sun)
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        //Level of heat of an object stored in Kelvin
        public double Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
            }
        }
        //List of bytes used for RGB.
        public List<byte> Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

    }
}
