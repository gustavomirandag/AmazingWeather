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
            ShowNextDaysWeather();

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

        private void ShowNextDaysWeather()
        {
            var weatherService = new WeatherService();
            var nextDaysWeather = weatherService.GetNextDaysWeather();

            foreach(var weather in nextDaysWeather.data)
            {
                StackLayout stackLayoutDay = new StackLayout()
                {
                    BackgroundColor = Color.LightBlue,
                    Padding = 20
                };

                //Cria um label o dia
                Label lbDate = new Label()
                {
                    Text = weather.date_br,
                    FontSize = 20
                };
                //Adiciono no StackLayout do dia
                stackLayoutDay.Children.Add(lbDate);

                //StackLayoutIcons
                StackLayout stackLayoutIcons = new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                //Cria a imagem da manhã
                Image imageMoorning = new Image()
                {
                    HorizontalOptions = LayoutOptions.Center
                };
                if (Device.RuntimePlatform == Device.UWP)
                    imageMoorning.Source = "Images/" + "mob" + weather.text_icon.icon.morning + ".png";
                else
                    imageMoorning.Source = "mob" + weather.text_icon.icon.morning + ".png";
                //Adiciona no Stack de Icons
                stackLayoutIcons.Children.Add(imageMoorning);

                //Cria a imagem da manhã
                Image imageDay = new Image()
                {
                    HorizontalOptions = LayoutOptions.Center
                };
                if (Device.RuntimePlatform == Device.UWP)
                    imageDay.Source = "Images/" + "mob" + weather.text_icon.icon.day + ".png";
                else
                    imageDay.Source = "mob" + weather.text_icon.icon.day + ".png";
                //Adiciona no Stack de Icons
                stackLayoutIcons.Children.Add(imageDay);

                //Cria a imagem da manhã
                Image imageNight = new Image()
                {
                    HorizontalOptions = LayoutOptions.Center
                };
                if (Device.RuntimePlatform == Device.UWP)
                    imageNight.Source = "Images/" + "mob" + weather.text_icon.icon.night + ".png";
                else
                    imageNight.Source = "mob" + weather.text_icon.icon.night + ".png";
                //Adiciona no Stack de Icons
                stackLayoutIcons.Children.Add(imageNight);

                //Adiciono a imagem ao StackLayout dos próximos dias
                stackLayoutDay.Children.Add(stackLayoutIcons);

                //Cria um label com a temperatura minima do dia
                Label lbTemperatureMin = new Label()
                {
                    Text = $"Min: {weather.temperature.min} ºC"
                };
                //Adiciona no StackDay
                stackLayoutDay.Children.Add(lbTemperatureMin);

                //Cria um label com a temperatura maxima do dia
                Label lbTemperatureMax = new Label()
                {
                    Text = $"Max: {weather.temperature.max} ºC"
                };
                //Adiciona no StackDay
                stackLayoutDay.Children.Add(lbTemperatureMax);

                //Cria o label com a descrição
                Label lbDescription = new Label()
                {
                    Text = weather.text_icon.text.phrase.reduced
                };
                //Adiciono no StackDay
                stackLayoutDay.Children.Add(lbDescription);

                //Adiciona no StackLayoutNextDays
                StackLayoutNextDays.Children.Add(stackLayoutDay);
            }
        }
	}
}
