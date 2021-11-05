using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;

namespace WeatherServices
{
    public class WeatherRequest
    {
        private string _APIKey = "a1f1e8e1ec3f72586c9f03df67514782";

        private double _lat { get; set; }
        private double _lon { get; set; }

        public async Task<WeatherInfo.root> GetWeatherToday(string city)
        {
            string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", city, _APIKey);
            WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(await GetJsonAsync(url));
            _lat = Info.coord.lat;
            _lon = Info.coord.lon;
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

        public async Task<SixDayForecastInfo.root> GetWeatherForecast()
        {
            string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=hourly,minutely,alerts&units=metric&appid={2}", _lat, _lon, _APIKey);
            using (WebClient web = new WebClient())
            {
                var Json = await web.DownloadStringTaskAsync(url);
                var Info = JsonConvert.DeserializeObject<SixDayForecastInfo.root>(Json);
                return Info;
            }
        }

        public void SetLatLon(double lat, double lon)
        {
            _lat = lat;
            _lon = lon;
        }
    }
}