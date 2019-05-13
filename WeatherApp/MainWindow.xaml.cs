using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WeatherApp.Models;

namespace WeatherApp
{
    public partial class MainWindow : Window
    {
        private Weather _weather;

        public MainWindow()
        {
            InitializeComponent();
            todayDockPanel.IsEnabled = false;
            daysStackPanel.IsEnabled = false;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void FindButtonClick(object sender, RoutedEventArgs e)
        {
            #region Получение координат
            string geoCodeUrl = $"https://geocode-maps.yandex.ru/1.x/?geocode={findTextBox.Text.ToLower()}&format=json";
            string json = "";
            WebClient client = new WebClient();
            using (Stream stream = client.OpenRead(geoCodeUrl))
            {
                using (var reader = new StreamReader(stream))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        json += line;
                    }
                }
            }
            GeoCodeService geoCodeService = new GeoCodeService();
            geoCodeService = JsonConvert.DeserializeObject<GeoCodeService>(json);
            if (geoCodeService.Response.GeoObjectCollection.MetaDataProperty.GeocoderResponseMetaData.BoundedBy is null)
            {
                MessageBox.Show("Wrong input!");
                return;
            }
            #endregion

            #region Получение данных о погоде

            bool isLongitude = true;
            string longitude = "";
            string latitude = "";

            foreach (var symbol in geoCodeService.Response.GeoObjectCollection.MetaDataProperty.GeocoderResponseMetaData.BoundedBy.Position.LowerCorner)
            {
                if (symbol == ' ')
                {
                    isLongitude = false;
                    continue;
                }
                if (isLongitude)
                {
                    longitude += symbol;
                }
                else
                {
                    latitude += symbol;
                }
            }

            WebRequest request = WebRequest.Create($"https://api.weather.yandex.ru/v1/forecast?lat={latitude}&lon={longitude}&extra=true&lang=ru_RU&limit=7");
            request.Headers.Add("X-Yandex-API-Key", "2f174269-cd88-4e10-9520-9a1e8f51dcf4");
            WebResponse response = request.GetResponse();
            json = "";
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        json += line;
                    }
                }
            }
            response.Close();

            _weather = new Weather();

            _weather = JsonConvert.DeserializeObject<Weather>(json);

            #endregion

            todayDockPanel.IsEnabled = true;
            daysStackPanel.IsEnabled = true;


            #region Заполнение данными
            firstDateLable.Content = _weather.Forecasts[0].Date;

            firstDayWeatherImage.Kind = GetWeatherImage(_weather.Forecasts[0].Parts.Day);

            firstNightTemperatureLable.Content = _weather.Forecasts[0].Parts.Night.TempAvg.ToString();
            firstMorningTemperatureLable.Content = _weather.Forecasts[0].Parts.Morning.TempAvg.ToString();
            firstDayTemperatureLable.Content = _weather.Forecasts[0].Parts.Day.TempAvg.ToString();
            firstEveningTemperatureLable.Content = _weather.Forecasts[0].Parts.Evening.TempAvg.ToString();


            secondDateLable.Content = _weather.Forecasts[1].Date;

            secondDayWeatherImage.Kind = GetWeatherImage(_weather.Forecasts[1].Parts.Day);

            secondNightTemperatureLable.Content = _weather.Forecasts[1].Parts.Night.TempAvg.ToString();
            secondMorningTemperatureLable.Content = _weather.Forecasts[1].Parts.Morning.TempAvg.ToString();
            secondDayTemperatureLable.Content = _weather.Forecasts[1].Parts.Day.TempAvg.ToString();
            secondEveningTemperatureLable.Content = _weather.Forecasts[1].Parts.Evening.TempAvg.ToString();


            thirdDateLable.Content = _weather.Forecasts[2].Date;

            thirdDayWeatherImage.Kind = GetWeatherImage(_weather.Forecasts[2].Parts.Day);

            thirdNightTemperatureLable.Content = _weather.Forecasts[2].Parts.Night.TempAvg.ToString();
            thirdMorningTemperatureLable.Content = _weather.Forecasts[2].Parts.Morning.TempAvg.ToString();
            thirdDayTemperatureLable.Content = _weather.Forecasts[2].Parts.Day.TempAvg.ToString();
            thirdEveningTemperatureLable.Content = _weather.Forecasts[2].Parts.Evening.TempAvg.ToString();


            fourthDateLable.Content = _weather.Forecasts[3].Date;

            fourthDayWeatherImage.Kind = GetWeatherImage(_weather.Forecasts[3].Parts.Day);

            fourthNightTemperatureLable.Content = _weather.Forecasts[3].Parts.Night.TempAvg.ToString();
            fourthMorningTemperatureLable.Content = _weather.Forecasts[3].Parts.Morning.TempAvg.ToString();
            fourthDayTemperatureLable.Content = _weather.Forecasts[3].Parts.Day.TempAvg.ToString();
            fourthEveningTemperatureLable.Content = _weather.Forecasts[3].Parts.Evening.TempAvg.ToString();


            fifthDateLable.Content = _weather.Forecasts[4].Date;

            fifthDayWeatherImage.Kind = GetWeatherImage(_weather.Forecasts[4].Parts.Day);

            fifthNightTemperatureLable.Content = _weather.Forecasts[4].Parts.Night.TempAvg.ToString();
            fifthMorningTemperatureLable.Content = _weather.Forecasts[4].Parts.Morning.TempAvg.ToString();
            fifthDayTemperatureLable.Content = _weather.Forecasts[4].Parts.Day.TempAvg.ToString();
            fifthEveningTemperatureLable.Content = _weather.Forecasts[4].Parts.Evening.TempAvg.ToString();


            sixthDateLable.Content = _weather.Forecasts[5].Date;

            sixthDayWeatherImage.Kind = GetWeatherImage(_weather.Forecasts[5].Parts.Day);

            sixthNightTemperatureLable.Content = _weather.Forecasts[5].Parts.Night.TempAvg.ToString();
            sixthMorningTemperatureLable.Content = _weather.Forecasts[5].Parts.Morning.TempAvg.ToString();
            sixthDayTemperatureLable.Content = _weather.Forecasts[5].Parts.Day.TempAvg.ToString();
            sixthEveningTemperatureLable.Content = _weather.Forecasts[5].Parts.Evening.TempAvg.ToString();


            seventhDateLable.Content = _weather.Forecasts[6].Date;

            seventhDayWeatherImage.Kind = GetWeatherImage(_weather.Forecasts[6].Parts.Day);

            seventhNightTemperatureLable.Content = _weather.Forecasts[6].Parts.Night.TempAvg.ToString();
            seventhMorningTemperatureLable.Content = _weather.Forecasts[6].Parts.Morning.TempAvg.ToString();
            seventhDayTemperatureLable.Content = _weather.Forecasts[6].Parts.Day.TempAvg.ToString();
            seventhEveningTemperatureLable.Content = _weather.Forecasts[6].Parts.Evening.TempAvg.ToString();
            #endregion
        }


        private MaterialDesignThemes.Wpf.PackIconKind GetWeatherImage(Day day)
        {

            if (day.Condition.Contains("rain"))
            {
                return MaterialDesignThemes.Wpf.PackIconKind.WeatherRainy;
            }
            if (day.Condition.Contains("clear"))
            {
                return MaterialDesignThemes.Wpf.PackIconKind.WeatherSunny;
            }
            if (day.Condition.Contains("overcast"))
            {
                return MaterialDesignThemes.Wpf.PackIconKind.WeatherCloudy;
            }
            if (day.Condition.Contains("cloud"))
            {
                return MaterialDesignThemes.Wpf.PackIconKind.WeatherCloudy;
            }

            return MaterialDesignThemes.Wpf.PackIconKind.WeatherSnowy;
        }

        private void firstDayButtonClick(object sender, RoutedEventArgs e)
        {
            FullInfoWindow fullInfoWindow = new FullInfoWindow(_weather.Forecasts[0].Parts);
            fullInfoWindow.Show();
        }
        private void secondDayButtonClick(object sender, RoutedEventArgs e)
        {
            FullInfoWindow fullInfoWindow = new FullInfoWindow(_weather.Forecasts[1].Parts);
            fullInfoWindow.Show();
        }
        private void thirdDayButtonClick(object sender, RoutedEventArgs e)
        {
            FullInfoWindow fullInfoWindow = new FullInfoWindow(_weather.Forecasts[2].Parts);
            fullInfoWindow.Show();
        }
        private void fourthDayButtonClick(object sender, RoutedEventArgs e)
        {
            FullInfoWindow fullInfoWindow = new FullInfoWindow(_weather.Forecasts[3].Parts);
            fullInfoWindow.Show();
        }
        private void fifthDayButtonClick(object sender, RoutedEventArgs e)
        {
            FullInfoWindow fullInfoWindow = new FullInfoWindow(_weather.Forecasts[4].Parts);
            fullInfoWindow.Show();
        }
        private void sixthDayButtonClick(object sender, RoutedEventArgs e)
        {
            FullInfoWindow fullInfoWindow = new FullInfoWindow(_weather.Forecasts[5].Parts);
            fullInfoWindow.Show();
        }
        private void seventhDayButtonClick(object sender, RoutedEventArgs e)
        {
            FullInfoWindow fullInfoWindow = new FullInfoWindow(_weather.Forecasts[6].Parts);
            fullInfoWindow.Show();
        }
    }
}
