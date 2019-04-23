using System;
using System.Windows;
using System.Windows.Media;

namespace CSCI4600_07_Team4Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void StarGenerator_Click(object sender, RoutedEventArgs e)
        {
            String starType = Convert.ToString(StarMainClassification.SelectedItem) + Convert.ToString(StarSubClassification.SelectedItem) + Convert.ToString(StarSuperSubClassification.SelectedItem); 
            CelestialSimulatorLibrary.Star s = new CelestialSimulatorLibrary.Star(starType);
            TemperatureText.Text = "Temp: " + Convert.ToString(s.Temperature) + "K";
            SolidColorBrush G = new SolidColorBrush(Color.FromRgb(s.Color[0], s.Color[1], s.Color[2]));
            visualObject.Fill = G;
            LuminosityText.Text = "Luminosity: " + Convert.ToString(s.Luminosity);

        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            SolidColorBrush G;
            LuminosityText.Visibility = Visibility.Collapsed;
            StarMainClassification.Visibility = Visibility.Collapsed;
            StarSubClassification.Visibility = Visibility.Collapsed;
            StarSuperSubClassification.Visibility = Visibility.Collapsed;
            StarGenerator.Visibility = Visibility.Collapsed;
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
                LuminosityText.Visibility = Visibility.Visible;
                StarGenerator.Visibility = Visibility.Visible;
                StarMainClassification.Visibility = Visibility.Visible;
                StarSubClassification.Visibility = Visibility.Visible;
                StarSuperSubClassification.Visibility = Visibility.Visible;
            }
           if(objectType == CelestialSimulatorLibrary.CelestialObjectBuilder.CelestialObjectType.NeutronStar)
            {
                G = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                visualObject.Fill = G;
                RadiusValue.Maximum = 20;
            }
           if(objectType == CelestialSimulatorLibrary.CelestialObjectBuilder.CelestialObjectType.BlackHole)
            {
                G = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                visualObject.Fill = G;
            }
        }

        private void RadiusValue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            visualObject.Width = visualObject.Height = RadiusValue.Value;
        }
    }
}
