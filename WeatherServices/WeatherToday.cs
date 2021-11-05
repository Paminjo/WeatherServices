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

        private WeatherRequest _weatherRequest = new WeatherRequest();
        private WeatherForecast weatherForecast = new WeatherForecast();

        private double _lat;
        private double _lon;
        private bool _checkWeatherToday = true;

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await this.GetWeather();
        }

        private async Task GetWeather()
        {
            try
            {
                var Info = await _weatherRequest.GetWeatherToday(TBCity.Text);

                _lat = Info.coord.lat;
                _lon = Info.coord.lon;

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

        private async void timer1_Tick(object sender, EventArgs e)
        {
            TimeOnSystem.Text = DateTime.Now.ToLongTimeString();
            if (TimeOnSystem.Text == "00:00:00")
            {
                DateOnSystem.Text = DateTime.Now.ToShortDateString();
            }
            if (weatherForecast.backToWeatherToday == true)
            {
                await GetWeather();// Fehler: 24/7 abfrage
                weatherForecast.Hide();
                this.Show();
            }
            if (weatherForecast.weatherForecastClosed)
            {
                this.Close();
            }
            if (weatherForecast.checkWeatherForecast)
            {
                this.DesktopLocation = weatherForecast.DesktopLocation;
            }
            if (_checkWeatherToday)
            {
                weatherForecast.DesktopLocation = this.DesktopLocation;
            }
            if (!weatherForecast.checkWeatherForecast)
            {
                _checkWeatherToday = true;
            }
            if(TBCity.Text != weatherForecast.cityName && weatherForecast.cityName != "")
            {
                TBCity.Text = weatherForecast.cityName;
            }
        }

        private void OpenWeatherForecast_Click(object sender, EventArgs e)
        {
            this.Hide();
            weatherForecast.backToWeatherToday = false;
            if (_lat != 0 && _lon != 0)
            {
                weatherForecast.GetFirstRequestForWeatherForecast(_lat, _lon, TBCity.Text);
            }

            weatherForecast.Show();
            weatherForecast.checkWeatherForecast = true;
            _checkWeatherToday = false;
        }

        private void WeatherService_LocationChanged(object sender, EventArgs e)
        {
            weatherForecast.DesktopLocation = this.DesktopLocation;
        }
    }
}