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
