using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialSimulatorLibrary
{
    class Star : CelestialObject
    {
        private double luminosity;
        // Star Classification based off of temperature going from hottest to coolest.
        private enum hRDiagramClass
        {
            O1, O2, O3, O4, O5, O6, O7, O8, O9,
            B1, B2, B3, B4, B5, B6, B7, B8, B9,
            A1, A2, A3, A4, A5, A6, A7, A8, A9,
            F1, F2, F3, F4, F5, F6, F7, F8, F9,
            G1, G2, G3, G4, G5, G6, G7, G8, G9,
            K1, K2, K3, K4, K5, K6, K7, K8, K9,
            M1, M2, M3, M4, M5, M6, M7, M8, M9
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
