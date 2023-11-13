using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace Ex_2308
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private const string KEY = "6bc03d4112343dff1e398d760f276199";

        private static HttpClient openWeatherClient = new HttpClient();

        Task<string> openWeatherTask = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void startBtn_Click(object sender, RoutedEventArgs e)
        {

            // Check if task is already running
            if (openWeatherTask?.Status != TaskStatus.RanToCompletion)
            {

                var result = MessageBox.Show(
                    "Cancel the current search?",
                    "Are you sure ?", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.No)
                {
                    return;
                }
                else
                {
                    openWeatherClient.CancelPendingRequests();
                }
            }

            Task<String> openWeatherGeoTask = getAPIData($"http://api.openweathermap.org/geo/1.0/direct?q={inputTbx.Text}&mode=xml&appid={KEY}");

            //openWeatherTask = getAPIData($"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&mode=xml&appid={KEY}");


            statusLbl.Content = "Proccessing Data";

        }

        private async Task<string> getAPIData(string url)
        {
            return null;
        }

    }
}
