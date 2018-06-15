using System;
using System.Collections.Generic;
using System.Text;

namespace ForecastApp.Model
{
    public class SingleDayWeather
    {
        public int id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public int temperature { get; set; }
        public string wind_direction { get; set; }
        public int wind_velocity { get; set; }
        public int humidity { get; set; }
        public string condition { get; set; }
        public int pressure { get; set; }
        public string icon { get; set; }
        public int sensation { get; set; }
        public string date { get; set; }
    }
}
