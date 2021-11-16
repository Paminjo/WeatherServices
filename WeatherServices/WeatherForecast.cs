using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherServices
{
    public partial class WeatherForecast : Form
    {
        public WeatherForecast()
        {
            InitializeComponent();
        }

        private WeatherRequest weatherRequest = new WeatherRequest();

        public bool checkWeatherForecast = false;
        public string cityName = "";
        public double lat { get; set; }
        public double lon { get; set; }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await GetRequestData();
        }

        private async Task GetRequestData()
        {
            try
            {
                var weatherToday = await weatherRequest.GetWeatherToday(TBCity.Text);
                cityName = TBCity.Text;
                lat = weatherToday.coord.lat;
                lon = weatherToday.coord.lon;
                weatherRequest.SetLatLon(weatherToday.coord.lat, weatherToday.coord.lon);
                await GetWeatherForecastData();
            }
            catch (WebException webEx)
            {
                MessageBox.Show(Convert.ToString(webEx));
            }
        }

        private async Task GetWeatherForecastData()
        {
            try
            {
                var Info = await weatherRequest.GetWeatherForecast();
                var DateTimeLabels = new Label[] { Date_0, Date_1, Date_2, Date_3, Date_4, Date_5 };
                var IconPictureBoxes = new PictureBox[] { Icon_0, Icon_1, Icon_2, Icon_3, Icon_4, Icon_5 };
                var ConditionLabels = new Label[] { Condition_0, Condition_1, Condition_2, Condition_3, Condition_4, Condition_5 };
                var DetailsLabels = new Label[] { Details_0, Details_1, Details_2, Details_3, Details_4, Details_5 };
                var TempLabels = new Label[] { ValueTemp_0, ValueTemp_1, ValueTemp_2, ValueTemp_3, ValueTemp_4, ValueTemp_5 };
                var TempMinLabels = new Label[] { ValueMinTemp_0, ValueMinTemp_1, ValueMinTemp_2, ValueMinTemp_3, ValueMinTemp_4, ValueMinTemp_5 };
                var TempMaxLabels = new Label[] { ValueMaxTemp_0, ValueMaxTemp_1, ValueMaxTemp_2, ValueMaxTemp_3, ValueMaxTemp_4, ValueMaxTemp_5 };

                double maxTemp = -200;
                double minTemp = 200;
                double avgTemp = 0;
                for (int i = 0; i <= 5; i++)
                {
                    DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    DateTimeLabels[i].Text = day.AddSeconds(Info.daily[i].dt).ToShortDateString();
                    TempMinLabels[i].Text = Convert.ToString(Info.daily[i].temp.min + "°C");
                    TempMaxLabels[i].Text = Convert.ToString(Info.daily[i].temp.max + "°C");
                    TempLabels[i].Text = Convert.ToString(Math.Round((Info.daily[i].temp.min + Info.daily[i].temp.max) / 2, 2)) + "°C";
                    IconPictureBoxes[i].ImageLocation = "https://api.openweathermap.org/img/w/" + Info.daily[i].weather[0].icon + ".png";

                    avgTemp += (Info.daily[i].temp.min + Info.daily[i].temp.max)/2;

                    if (maxTemp < Info.daily[i].temp.max)
                    {
                        maxTemp = Info.daily[i].temp.max;
                    }
                    if (minTemp > Info.daily[i].temp.min)
                    {
                        minTemp = Info.daily[i].temp.min;
                    }
                }
                avgTemp /= 6;

                ValueAvgWeekTemp.Text = Convert.ToString(Math.Round(avgTemp, 2)) + "°C";
                ValueMaxWeekTemp.Text = Convert.ToString(maxTemp) + "°C";
                ValueMinWeekTemp.Text = Convert.ToString(minTemp) + "°C";
            }
            catch (WebException webEx)
            {
                MessageBox.Show(Convert.ToString(webEx));
            }
        }

        public async void GetFirstRequestForWeatherForecast(double lat, double lon, string city)
        {
            weatherRequest.SetLatLon(lat, lon);
            TBCity.Text = city;
            await GetWeatherForecastData();
        }

        private void back_Click(object sender, EventArgs e)
        {
            backToWeatherToday = true;
            checkWeatherForecast = false;
        }

        public bool backToWeatherToday { get; set; }

        public bool weatherForecastClosed { get; set; }

        private void WeatherForecast_FormClosed(object sender, FormClosedEventArgs e)
        {
            weatherForecastClosed = true;
        }

        private async void TBCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await GetRequestData();
            }
        }
    }
}