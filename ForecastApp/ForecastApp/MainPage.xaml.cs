using ForecastApp.Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ForecastApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            ShowCurrentWeather();
		}

        private void ShowCurrentWeather()
        {
            WeatherService service = new WeatherService();
            var weather = service.GetCurrentWeather();
            if (Device.RuntimePlatform == Device.UWP)
                ImageIcon.Source = "Images/" + "mob" + weather.data.icon + ".png";
            else
                ImageIcon.Source = "mob" + weather.data.icon + ".png";
            LbState.Text = weather.name;
            LbDate.Text = Convert.ToDateTime(weather.data.date)
                .ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            LbTemp.Text = weather.data.temperature.ToString() + " ºC";
            LbReview.Text = weather.data.condition;
        }
	}
}
