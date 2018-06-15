using ForecastApp.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ForecastApp.Service
{
    public class WeatherService
    {
        public SingleDayWeather GetCurrentWeather()
        {
            WebRequest webRequest = WebRequest.Create("http://apiadvisor.climatempo.com.br/api/v1/weather/locale/5959/current?token=DIGITE_AQUI_SEU_TOKEN");
            var response = webRequest.GetResponseAsync();
            WebHeaderCollection header = response.Result.Headers;

            string serializedWeather;
            using (var reader = new System.IO.StreamReader(response.Result.GetResponseStream()))
            {
                serializedWeather = reader.ReadToEnd();
            }
            SingleDayWeather weather = Newtonsoft.Json.JsonConvert.DeserializeObject<SingleDayWeather>(serializedWeather);

            return weather;
        }

        //public SingleDayWeather GetCurrentWeather()
        //{
        //    WebClient webClient = new WebClient();
        //    string serializedWeather = webClient.DownloadString("http://apiadvisor.climatempo.com.br/api/v1/weather/locale/5959/current?token=c04bb061adc4fe108259c3c8e034ef88");
        //    SingleDayWeather weather = Newtonsoft.Json.JsonConvert.DeserializeObject<SingleDayWeather>(serializedWeather);

        //    return weather;
        //}
    }
}
