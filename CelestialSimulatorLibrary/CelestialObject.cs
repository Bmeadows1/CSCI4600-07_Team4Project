using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
    public abstract class CelestialObject
    {
        private string name;
        private double radius;
        private double temperature;
        private double coreRadius;

        public CelestialObject()
        {
        }

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
        //Level of heat of an object
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
        //Radius of core of object
        public double CoreRadius
        {
            get
            {
                return coreRadius;
            }
            set
            {
                coreRadius = value;
            }
        }
    }
}
