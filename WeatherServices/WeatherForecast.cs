using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WeatherServices
{
    public partial class WeatherForecast : Form
    {
        public WeatherForecast()
        {
            InitializeComponent();
            
        }
        private double _lat;
        private double _lon;
        private void TBCity_TextChanged(object sender, EventArgs e)
        {
        }

        public readonly string APIKey = "a1f1e8e1ec3f72586c9f03df67514782";

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await this.GetForecastData();
        }

        private async Task  GetForecastData()
        {
            string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=hourly,minutely,alerts&units=metric&appid={2}",_lat,_lon, APIKey);
            using (WebClient web = new WebClient())
            {
                var json = await web.DownloadStringTaskAsync(url);
                SixDayForecastInfo.root info = JsonConvert.DeserializeObject<SixDayForecastInfo.root>(json);            
                var DateTimeLabels = new Label[] { Date_0, Date_1, Date_2, Date_3, Date_4 };
                var IconPictureBoxes = new PictureBox[] { Icon_0, Icon_1, Icon_2, Icon_3, Icon_4 };
                var ConditionLabels = new Label[] { Condition_0, Condition_1, Condition_2, Condition_3, Condition_4 };
                var DetailsLabels = new Label[] { Details_0, Details_1, Details_2, Details_3, Details_4 };
                var TempLabels = new Label[] { ValueTemp_0, ValueTemp_1, ValueTemp_2, ValueTemp_3, ValueTemp_4 };
                var TempMinLabels = new Label[] { ValueMinTemp_0, ValueMinTemp_1, ValueMinTemp_2, ValueMinTemp_3, ValueMinTemp_4 };
                var TempMaxLabels = new Label[] { ValueMaxTemp_0, ValueMaxTemp_1, ValueMaxTemp_2, ValueMaxTemp_3, ValueMaxTemp_4 };

                for (int i = 0; i <= 4; i++)
                {
                    DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    DateTimeLabels[i].Text = day.AddSeconds(info.daily[i].dt).ToShortDateString();
                    TempMinLabels[i].Text = Convert.ToString(info.daily[i].temp.min + " °C");
                    TempMaxLabels[i].Text = Convert.ToString(info.daily[i].temp.max + " °C");
                    TempLabels[i].Text = Convert.ToString((info.daily[i].temp.min + info.daily[i].temp.max)/2);
                    IconPictureBoxes[i].ImageLocation = "https://api.openweathermap.org/img/w/" + info.daily[i].weather[0].icon + ".png";
                }

            }
        }

        public void GetFirstRequest(double lat, double lon, string city)
        {
            _lat = lat;
            _lon = lon;
            TBCity.Text = city;
            GetForecastData();
        }

        private void WeatherForecast_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void WeatherForecast_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}