using System;

namespace SimpleAPI
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 64 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public object Get(int v)
        {
            return TemperatureF;
        }
    }
}
