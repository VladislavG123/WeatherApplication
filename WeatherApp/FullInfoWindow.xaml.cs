using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WeatherApp.Models;

namespace WeatherApp
{
    /// <summary>
    /// Логика взаимодействия для FullInfoWindow.xaml
    /// </summary>
    public partial class FullInfoWindow : Window
    {
        public FullInfoWindow(Parts parts)
        {
            InitializeComponent();

            nightFeelsLike.Text += " " + parts.Night.FeelsLike + " C";
            nightTemperature.Text += " " + parts.Night.TempMin + "..." + parts.Night.TempMax + " C";
            nightWindSpeed.Text += " " + parts.Night.WindSpeed;
            nightWindDirrection.Text += " " + parts.Night.WindDirrection.ToUpper();

            morningFeelsLike.Text += " " + parts.Morning.FeelsLike + " C";
            morningTemperature.Text += " " + parts.Morning.TempMin + "..." + parts.Night.TempMax + " C";
            morningWindSpeed.Text += " " + parts.Morning.WindSpeed;
            morningWindDirrection.Text += " " + parts.Morning.WindDirrection.ToUpper();

            dayFeelsLike.Text += " " + parts.Day.FeelsLike + " C";
            dayTemperature.Text += " " + parts.Day.TempMin + "..." + parts.Night.TempMax + " C";
            dayWindSpeed.Text += " " + parts.Day.WindSpeed;
            dayWindDirrection.Text += " " + parts.Day.WindDirrection.ToUpper();

            eveningFeelsLike.Text += " " + parts.Evening.FeelsLike + " C";
            eveningTemperature.Text += " " + parts.Evening.TempMin + "..." + parts.Night.TempMax + " C";
            eveningWindSpeed.Text += " " + parts.Evening.WindSpeed;
            eveningWindDirrection.Text += " " + parts.Evening.WindDirrection.ToUpper();

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
