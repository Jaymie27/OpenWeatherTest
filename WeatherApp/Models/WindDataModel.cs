using System;

namespace WeatherApp.Models
{
    public class WindDataModel
    {
        public DateTime DateTime { get; set; }
        public double MetrePerSec { get; set; }
        public double Direction { get; set; }
    }
}
