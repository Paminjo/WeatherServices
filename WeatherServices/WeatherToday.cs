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

            // Thermometer-Grafik Einstellungen werden festgelegt;
            thermometer.Controls.Add(tempratureBar);
            tempratureBar.Height = 0;
            tempratureBar.Location = new Point(63, 430);
            tempratureBar.BackColor = Color.Transparent;

            // Thermometer kriegt ein Steuerelement den BarFiller
            thermometer.Controls.Add(colorBarFiller);
            colorBarFiller.Height = 0;
            colorBarFiller.Location = new Point(63, 430);
            colorBarFiller.BackColor = Color.Transparent;

            // Zwei Timer werden gestartet einer Für die Aktuelle Zeit der andere um Eigenschaften zu Überprüfen und
            // dementsprechen zu agieren
            DateOnSystem.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
            timer2.Start();
        }

        // Erstellt benötigte Objekte
        private WeatherRequest _weatherRequest = new WeatherRequest();
        private WeatherForecast weatherForecast = new WeatherForecast();

        // private Eigenschaften die genutzt werden für überprüfungen und daten übertragung/abgleich
        private double _lat;
        private double _lon;
        private bool _checkWeatherToday = true;

        // Die Button_Click Methode 
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            
            await this.GetWeather();
        }
        
        // holt die Wetterdaten und setzt sie ein
        private async Task GetWeather()
        {
            // Fehleranfälliger Code bzw. alles was Fehler verursachen könnte
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

                temp_Max.Text = Convert.ToString(Math.Round(Info.main.temp_max - 273.15, 2)) + "°C";
                temp_Min.Text = Convert.ToString(Math.Round(Info.main.temp_min - 273.15, 2)) + "°C";
                ActualTemp.Text = Convert.ToString(Math.Round(Info.main.temp - 273.15, 2)) + "°C";
                labWindSpeed.Text = Info.wind.speed.ToString();
                labPressure.Text = Info.main.pressure.ToString();

                labWindSpeed.Text = Info.wind.speed.ToString() + " mph";
                labPressure.Text = Info.main.pressure.ToString() + " mb";
                ChangeTempInThermometer(Info.main.temp);
            }
            // Fehler werden abgefangen und in einer Messagebox angezeigt -> man kann den schöner aussehen lassen, aber reicht mir
            catch (WebException e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
        }

        // holt sich den Bild-String aus dem Internet
        private async Task<string> GetWeatherIconAsync(string iconString)
        {
            string icon = "https://api.openweathermap.org/img/w/" + iconString + ".png";
            return icon;
        }

        // Ändert die Thermometer-Grafik
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

        // TextBox Event KeyDown, wenn während der Bedienung der TextBox Enter gedrückt wird es ausgeführt
        private async void TBCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await GetWeather();
            }
        }

        // Timer um im Millisekundentakt die Uhrezeit aus dem System zuholen
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeOnSystem.Text = DateTime.Now.ToLongTimeString();
            if (TimeOnSystem.Text == "00:00:00")
            {
                DateOnSystem.Text = DateTime.Now.ToShortDateString();
            }

        }

        // Zweites Form bzw. das WeatherForecastForm wird sichtbar gemacht, welches man vorher erstellt hat
        // Außerdem wird wenn eine Abfrage getätigt wurde, diese schon beim öffnen als Forecast auch ausgeführt
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

        // Wenn die Desktop Location von dieser Form geändert wird, übertragt dieser die Werte auf das weatherForecast Objekt, welches versteckt ist
        private void WeatherService_LocationChanged(object sender, EventArgs e)
        {
            weatherForecast.DesktopLocation = this.DesktopLocation;
        }

        // Der Zweite Timer, dieseer wird für überprüfungen und datenabfragen zur untergeordneten Form verwendet
        private async void timer2_Tick(object sender, EventArgs e)
        {
            if (TBCity.Text != weatherForecast.cityName && weatherForecast.cityName != ""
                    && weatherForecast.backToWeatherToday == false )
            {
                TBCity.Text = weatherForecast.cityName;
                
            } 
            if (weatherForecast.backToWeatherToday == true)
            {
                if (_lat != weatherForecast.lat && _lon != weatherForecast.lon && weatherForecast.gotBack == 'y')
                {
                    await GetWeather();
                    weatherForecast.gotBack = 'n';
                }
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

        }
    }
}