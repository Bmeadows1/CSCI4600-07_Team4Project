using System.Windows;

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
            CelestialSimulatorLibrary.CelestialObjectBuilder celestialObject = new CelestialSimulatorLibrary.CelestialObjectBuilder(CelestialSimulatorLibrary.CelestialObjectBuilder.CelestialObjectType.Star);
        }
    }
}