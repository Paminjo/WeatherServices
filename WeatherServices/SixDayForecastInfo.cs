using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherServices
{
    public class SixDayForecastInfo
    {
        public class current
        {
            public long dt { get; set; }
            public double temp { get; set; }
            public double feels_like { get; set; }
            public long humidity { get; set; }
            public long pressure { get; set; }
            public double wind_speed { get; set; }
            public List<weather> weather { get; set; }
        }
        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }
        public class temp
        {
            public double min { get; set; }
            public double max { get; set; }
        }
        public class daily 
        {
            public long dt { get; set; }
            public long humidity { get; set; }
            public long pressure { get; set; }
            public double wind_speed { get; set; }
            public temp temp { get; set; }
            public List<weather> weather { get; set; }
        }
        public class root
        {
            public long timezone_offset { get; set; }
            public current current { get; set; }
            public List<daily> daily { get; set; }
        }
    }
}
