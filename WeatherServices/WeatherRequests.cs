using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherServices
{
    public class WeatherRequest
    {
        private string _APIKey = "a1f1e8e1ec3f72586c9f03df67514782";

        public async Task<WeatherInfo.root> GetWeather(string city)
        {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", city, _APIKey);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(await GetJsonAsync(url));
                return Info;
        }
        private async Task<string> GetJsonAsync(string url)
        {
            using (WebClient web = new WebClient())
            {
                var json = await web.DownloadStringTaskAsync(url);
                return json;
            }
        }
    }
}
