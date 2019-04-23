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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String starType = Convert.ToString(StarMainClassification.SelectedItem) + Convert.ToString(StarSubClassification.SelectedItem) + Convert.ToString(StarSuperSubClassification.SelectedItem); 
            CelestialSimulatorLibrary.Star s = new CelestialSimulatorLibrary.Star(starType);

            TemperatureText.Text = "Temp: " + Convert.ToString(s.Temperature) + "K";
            visualObject.Width = s.Radius * 100;
            SolidColorBrush G = new SolidColorBrush(Color.FromRgb(s.Color[0], s.Color[1], s.Color[2]));
            visualObject.Fill = G;

        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            StarMainClassification.Visibility = Visibility.Collapsed;
            StarSubClassification.Visibility = Visibility.Collapsed;
            StarSuperSubClassification.Visibility = Visibility.Collapsed;


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
                StarMainClassification.Visibility = Visibility.Visible;
                StarSubClassification.Visibility = Visibility.Visible;
                StarSuperSubClassification.Visibility = Visibility.Visible;
            }

        }
    }
}
