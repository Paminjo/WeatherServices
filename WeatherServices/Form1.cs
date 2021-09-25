using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace WeatherServices
{
    public partial class WeatherService : Form
    {
        public WeatherService()
        {
            InitializeComponent();

            thermometer.Controls.Add(tempratureBar);
            tempratureBar.Height = 0;
            tempratureBar.Location = new Point(63, 430);
            tempratureBar.BackColor = Color.Transparent;

            thermometer.Controls.Add(colorBarFiller);
            colorBarFiller.Height = 0;
            colorBarFiller.Location = new Point(63, 430);
            colorBarFiller.BackColor = Color.Transparent;
        }

        private string APIKey = "a1f1e8e1ec3f72586c9f03df67514782";


            public void GetThermometer()
            {

            }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetWeather();
        }

        private void GetWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                picIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labCondition.Text = Info.weather[0].main;
                labDetails.Text = Info.weather[0].description;
                labSunset.Text = ConvertDateTime(Info.sys.sunset).ToShortTimeString();
                labSunrise.Text = ConvertDateTime(Info.sys.sunrise).ToShortTimeString();

                labWindSpeed.Text = Info.wind.speed.ToString();
                labPressure.Text = Info.main.pressure.ToString();

                double temp = Info.main.temp-273.15;
                double heightGrowth = (temp + 20) * 6;
                thermometer.Controls.Add(tempratureBar);
                tempratureBar.Height = Convert.ToInt32(heightGrowth);
                tempratureBar.Location = new Point(63, 472 - Convert.ToInt32(heightGrowth));
                tempratureBar.BackColor = Color.Transparent;
                if (temp > 0)
                {
                    colorBarFiller.Height = 30;
                    colorBarFiller.Location = new Point(63, 442);
                    colorBarFiller.BackColor = Color.Transparent;
                }
            }
        }
        DateTime ConvertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();
            return day;
        }
    }
}