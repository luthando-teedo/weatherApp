using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class WeatherReport
    {
        public static async Task<string> GetWeatherReportAsync()
        {
            HttpClient httpClient = new HttpClient();

            string weatherReporter = await httpClient.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?q=Cape%20town&APPID=475eaa798f0db7fdcc9aa7f7629ef9d5&units=metric");

            CapeTownWeather weather = JsonConvert.DeserializeObject<CapeTownWeather>(weatherReporter);
            int humidity = weather.main.humidity;
            int Temperature = Convert.ToInt32 (weather.main.temp);
            string weatherTellTemp = $"{Temperature}";

            string outPut = $"{weatherTellTemp} ";

            return outPut;

        }


        public static async Task<string> GetWindAsync()
        {
            HttpClient httpClient = new HttpClient();

            string weatherReporter = await httpClient.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?q=Cape%20town&APPID=475eaa798f0db7fdcc9aa7f7629ef9d5&units=metric");

            CapeTownWeather weather = JsonConvert.DeserializeObject<CapeTownWeather>(weatherReporter);
            double Wind = weather.wind.speed;
            string WindSpeed = $"{Wind}";

            string outPut = $"{WindSpeed} ";

            return outPut;

        }
    }
}
