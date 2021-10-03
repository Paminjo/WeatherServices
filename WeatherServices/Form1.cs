using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
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

            DateOnSystem.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
        }

        private string APIKey = "a1f1e8e1ec3f72586c9f03df67514782";

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await this.GetWeather();
        }

        private async Task GetWeather()
        {
            try
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, APIKey);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(await GetJsonAsync(url));

                picIcon.ImageLocation = await GetWeatherIconAsync(Info.weather[0].icon);
                labCondition.Text = Info.weather[0].main;
                labDetails.Text = Info.weather[0].description;
                labSunset.Text = ConvertDateTime(Info.sys.sunset, Info.timezone).ToShortTimeString();
                labSunrise.Text = ConvertDateTime(Info.sys.sunrise, Info.timezone).ToShortTimeString();

                ActualTimeInSerachedRegion.Text = ConvertDateTime(Info.dt, Info.timezone).ToLongTimeString();
                
                labWindSpeed.Text = Info.wind.speed.ToString();
                labPressure.Text = Info.main.pressure.ToString();

                labWindSpeed.Text = Info.wind.speed.ToString() + " mph";
                labPressure.Text = Info.main.pressure.ToString() + " mb";
                ChangeTempInThermometer(Info.main.temp);
            }
            catch (WebException e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
        }

        private async void UpdateWeatherServiceAsync(WeatherInfo.root Info)
        {
            picIcon.ImageLocation = await GetWeatherIconAsync(Info.weather[0].icon);
            labCondition.Text = Info.weather[0].main;
            labDetails.Text = Info.weather[0].description;
            labSunset.Text = ConvertDateTime(Info.sys.sunset, Info.timezone).ToShortTimeString();
            labSunrise.Text = ConvertDateTime(Info.sys.sunrise, Info.timezone).ToShortTimeString();

            ActualTimeInSerachedRegion.Text = ConvertDateTime(Info.dt, Info.timezone).ToLongTimeString();

            labWindSpeed.Text = Info.wind.speed.ToString() + " mph";
            labPressure.Text = Info.main.pressure.ToString() + " mb";
            ChangeTempInThermometer(Info.main.temp);
        }

        private async Task<string> GetJsonAsync(string url)
        {
            using (WebClient web = new WebClient())
            {
                var json = await web.DownloadStringTaskAsync(url);
                return json;
            }
        }

        private async Task<string> GetWeatherIconAsync(string iconString)
        {
            string icon = "https://api.openweathermap.org/img/w/" + iconString + ".png";
            return icon;
        }

        private void ChangeTempInThermometer(double temp)
        {
            temp = temp - 273.15;
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

        private DateTime ConvertDateTime(long sec, long timezone)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            day = day.AddSeconds(sec + timezone);
            return day;
        }

        private async void TBCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await GetWeather();
            }
        }

        private void TimeOnSystem_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeOnSystem.Text = DateTime.Now.ToLongTimeString();
            if (TimeOnSystem.Text == "00:00:00")
            {
                DateOnSystem.Text = DateTime.Now.ToShortDateString();
            }
        }
    }
}