using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;

namespace WeatherServices
{
    public partial class WeatherForecast : Form
    {
        public WeatherForecast()
        {
            InitializeComponent();
        }

        private void TBCity_TextChanged(object sender, EventArgs e)
        {
        }

        public readonly string APIKey = "a1f1e8e1ec3f72586c9f03df67514782";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?q={0}&units=metric&appid={1}", TBCity.Text, APIKey);
            using (WebClient web = new WebClient())
            {
                var json = web.DownloadString(url);
                WeatherForecastInfo.root Info = JsonConvert.DeserializeObject<WeatherForecastInfo.root>(json);
            }
        }
    }
}