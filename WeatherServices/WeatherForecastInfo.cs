using System.Collections.Generic;

namespace WeatherServices
{
    public class WeatherForecastInfo
    {
        public class list
        {
            public long dt { get; set; }
            public main main { get; set; }
            public List<weather> weather { get; set; }
            public string dt_txt { get; set; }
        }

        public class main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
        }

        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class root
        {
            public List<list> list { get; set; }
        }
    }
}