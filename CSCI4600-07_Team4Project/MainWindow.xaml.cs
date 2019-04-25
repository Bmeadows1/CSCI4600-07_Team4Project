using System;
using System.Windows;
using System.Windows.Media;

namespace CSCI4600_07_Team4Project
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Button which generates star
        private void StarGenerator_Click(object sender, RoutedEventArgs e)
        {
            String starType = Convert.ToString(StarMainClassification.SelectedItem) + 
                Convert.ToString(StarSubClassification.SelectedItem) + 
                Convert.ToString(StarSuperSubClassification.SelectedItem); 

            CelestialSimulatorLibrary.Star s = new CelestialSimulatorLibrary.Star(starType);

            TemperatureText.Text = "Temp: " + Convert.ToString(s.Temperature) + "K";

            SolidColorBrush G = new SolidColorBrush(Color.FromRgb(s.Color[0], s.Color[1], s.Color[2]));
            visualObject.Fill = G;

            LuminosityText.Text = "Luminosity: " + Convert.ToString(s.Luminosity);
        }
        //Button which generates Neutron Star
        private void NeutronStarGenerator_Click(object sender, RoutedEventArgs e)
        {
            CelestialSimulatorLibrary.NeutronStar ns = new CelestialSimulatorLibrary.NeutronStar();

            TemperatureText.Text = "Temp: " + Convert.ToString(ns.Temperature);

           SolidColorBrush G = new SolidColorBrush(Color.FromRgb(ns.Color[0], ns.Color[1], ns.Color[2]));
            visualObject.Fill = G;
        }
        //Button which generates Black Hole
        private void BlackHoleGenerator_Click(object sender, RoutedEventArgs e)
        {
            CelestialSimulatorLibrary.BlackHole bh = new CelestialSimulatorLibrary.BlackHole();

            TemperatureText.Text = "Temp: " + Convert.ToString(bh.Temperature);

            SolidColorBrush G = new SolidColorBrush(Color.FromRgb(bh.Color[0], bh.Color[1], bh.Color[2]));
            visualObject.Fill = G;
        }
        //Button which generates Gas Planet
        private void GasPlanetGenerator_Click(object sender, RoutedEventArgs e)
        {
            CelestialSimulatorLibrary.GasPlanet.gasType atmosphereType =
                           (CelestialSimulatorLibrary.GasPlanet.gasType)
                           Enum.Parse(typeof(CelestialSimulatorLibrary.GasPlanet.gasType),
                           Convert.ToString(GasType.SelectedItem), true);

            CelestialSimulatorLibrary.GasPlanet gp = new CelestialSimulatorLibrary.GasPlanet(atmosphereType);

            SolidColorBrush G = new SolidColorBrush(Color.FromRgb(gp.Color[0], gp.Color[1], gp.Color[2]));
            visualObject.Fill = G;
        }
        //Button which generates Liquid Planet
        private void LiquidPlanetGenerator_Click(object sender, RoutedEventArgs e)
        {
            CelestialSimulatorLibrary.LiquidPlanet lp = new CelestialSimulatorLibrary.LiquidPlanet();

            SolidColorBrush G = new SolidColorBrush(Color.FromRgb(lp.Color[0], lp.Color[1], lp.Color[2]));
            visualObject.Fill = G;
        }
        //Button which generates Rock Planet
        private void RockPlanetGenerator_Click(object sender, RoutedEventArgs e)
        {
            CelestialSimulatorLibrary.RockPlanet.surfaceType planetType =
                           (CelestialSimulatorLibrary.RockPlanet.surfaceType)
                           Enum.Parse(typeof(CelestialSimulatorLibrary.RockPlanet.surfaceType),
                           Convert.ToString(RockType.SelectedItem), true);

            CelestialSimulatorLibrary.RockPlanet rp = new CelestialSimulatorLibrary.RockPlanet(planetType);

            SolidColorBrush G = new SolidColorBrush(Color.FromRgb(rp.Color[0], rp.Color[1], rp.Color[2]));
            visualObject.Fill = G;

        }
        //Choosing type of celestial object and managing UI components
        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            OurSun.Visibility = Visibility.Collapsed;

            LuminosityText.Visibility = Visibility.Collapsed;

            StarMainClassification.Visibility = Visibility.Collapsed;

            StarSubClassification.Visibility = Visibility.Collapsed;

            StarSuperSubClassification.Visibility = Visibility.Collapsed;

            StarGenerator.Visibility = Visibility.Collapsed;

            Earth.Visibility = Visibility.Collapsed;

            NeutronStarGenerator.Visibility = Visibility.Collapsed;

            BlackHoleGenerator.Visibility = Visibility.Collapsed;

            GasType.Visibility = Visibility.Collapsed;

            GasPlanetGenerator.Visibility = Visibility.Collapsed;

            LiquidPlanetGenerator.Visibility = Visibility.Collapsed;

            RockPlanetGenerator.Visibility = Visibility.Collapsed;

            RockType.Visibility = Visibility.Collapsed;

            RadiusValue.Maximum = 5000;


            //Wow there must be a better way to do this
            CelestialSimulatorLibrary.CelestialObjectBuilder.CelestialObjectType objectType = 
                (CelestialSimulatorLibrary.CelestialObjectBuilder.CelestialObjectType)
                Enum.Parse(typeof(CelestialSimulatorLibrary.CelestialObjectBuilder.CelestialObjectType), 
                Convert.ToString(CelestialObjectSelector.SelectedItem), true);

            CelestialSimulatorLibrary.CelestialObjectBuilder celestialBuilder = 
                new CelestialSimulatorLibrary.CelestialObjectBuilder(objectType);

            TypeText.Text = "Type: " + Convert.ToString(objectType);

           if(objectType == CelestialSimulatorLibrary.CelestialObjectBuilder.CelestialObjectType.Star)
            {
                OurSun.Visibility = Visibility.Visible;

                LuminosityText.Visibility = Visibility.Visible;

                StarGenerator.Visibility = Visibility.Visible;

                StarMainClassification.Visibility = Visibility.Visible;

                StarSubClassification.Visibility = Visibility.Visible;

                StarSuperSubClassification.Visibility = Visibility.Visible;
            }

           if(objectType == CelestialSimulatorLibrary.CelestialObjectBuilder.CelestialObjectType.NeutronStar)
            {
                NeutronStarGenerator.Visibility = Visibility.Visible;

                OurSun.Visibility = Visibility.Visible;

                RadiusValue.Maximum = 200;
            }

           if(objectType == CelestialSimulatorLibrary.CelestialObjectBuilder.CelestialObjectType.BlackHole)
            {
                OurSun.Visibility = Visibility.Visible;

                BlackHoleGenerator.Visibility = Visibility.Visible;
            }

            if (objectType == CelestialSimulatorLibrary.CelestialObjectBuilder.CelestialObjectType.GasPlanet)
            {
                GasPlanetGenerator.Visibility = Visibility.Visible;

                GasType.Visibility = Visibility.Visible;

                Earth.Visibility = Visibility.Visible;

                RadiusValue.Maximum = 450;
            }
            if (objectType == CelestialSimulatorLibrary.CelestialObjectBuilder.CelestialObjectType.LiquidPlanet)
            {
                LiquidPlanetGenerator.Visibility = Visibility.Visible;

                Earth.Visibility = Visibility.Visible;

                RadiusValue.Maximum = 450;
            }
            if (objectType == CelestialSimulatorLibrary.CelestialObjectBuilder.CelestialObjectType.RockPlanet)
            {
                RockType.Visibility = Visibility.Visible;

                RockPlanetGenerator.Visibility = Visibility.Visible;

                Earth.Visibility = Visibility.Visible;

                RadiusValue.Maximum = 450;
            }
        }
        //Changes radius of visualObject
        private void RadiusValue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            visualObject.Width = visualObject.Height = RadiusValue.Value;
        }
    }
}
