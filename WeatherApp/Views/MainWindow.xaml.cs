using OpenWeatherAPI;
using System.Windows;
using WeatherApp.ViewModels;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WindDataViewModel vm;

        public MainWindow()
        {
            InitializeComponent();

            ApiHelper.InitializeClient();

            /// TODO : Faire les appels de configuration ici ainsi que l'initialisation

            vm = new WindDataViewModel();

            DataContext = vm;           
        }
    }
}
