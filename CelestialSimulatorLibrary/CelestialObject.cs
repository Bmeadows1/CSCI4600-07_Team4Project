using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CelestialSimulatorLibrary
{
    public abstract class CelestialObject
    {
        private List<Byte> color;
        private string name;
        private double radius;
        private Double temperature;


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
        public List<Byte> Color
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

    }
}
