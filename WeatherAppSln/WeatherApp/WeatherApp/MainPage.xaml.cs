using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DisplayStuff();
        }

        
        public async void DisplayStuff()
        {
            ActivityInd.IsVisible = true;
            ActivityInd.IsRunning = true;
            var stuff = await WeatherReport.GetWeatherReportAsync();
            largeNumber.Text = stuff;

            var windSpeed = await WeatherReport.GetWindAsync();
            Windspeed.Text = windSpeed;
            ActivityInd.IsVisible = false;
            ActivityInd.IsRunning = false;
        }

        
        
    }
}
