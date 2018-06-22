using System;
using System.Collections.Generic;
using System.Text;

namespace ForecastApp.Model
{
    public class MultipleDaysWeather
    {
        public int id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public Datum[] data { get; set; }
    }

    public class Datum
    {
        public string date { get; set; }
        public string date_br { get; set; }
        public Humidity humidity { get; set; }
        public Rain rain { get; set; }
        public Wind wind { get; set; }
        public Uv uv { get; set; }
        public Thermal_Sensation thermal_sensation { get; set; }
        public Text_Icon text_icon { get; set; }
        public Temperature temperature { get; set; }
    }

    public class Humidity
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Rain
    {
        public int probability { get; set; }
        public int precipitation { get; set; }
    }

    public class Wind
    {
        public int velocity_min { get; set; }
        public int velocity_max { get; set; }
        public int velocity_avg { get; set; }
        public float gust_max { get; set; }
        public int direction_degrees { get; set; }
        public string direction { get; set; }
    }

    public class Uv
    {
        public int max { get; set; }
    }

    public class Thermal_Sensation
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Text_Icon
    {
        public Icon icon { get; set; }
        public Text text { get; set; }
    }

    public class Icon
    {
        public string dawn { get; set; }
        public string morning { get; set; }
        public string afternoon { get; set; }
        public string night { get; set; }
        public string day { get; set; }
    }

    public class Text
    {
        public string pt { get; set; }
        public string en { get; set; }
        public string es { get; set; }
        public Phrase phrase { get; set; }
    }

    public class Phrase
    {
        public string reduced { get; set; }
        public string morning { get; set; }
        public string afternoon { get; set; }
        public string night { get; set; }
        public string dawn { get; set; }
    }

    public class Temperature
    {
        public int min { get; set; }
        public int max { get; set; }
        public Morning morning { get; set; }
        public Afternoon afternoon { get; set; }
        public Night night { get; set; }
    }

    public class Morning
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Afternoon
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Night
    {
        public int min { get; set; }
        public int max { get; set; }
    }
        
}
