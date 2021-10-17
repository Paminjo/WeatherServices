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
            string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat=33.44&lon=-94.04&exclude=hourly,minutely,alerts&units=metric&appid={0}", APIKey);
            using (WebClient web = new WebClient())
            {
                var json = web.DownloadString(url);
                SixDayForecastInfo.root info = JsonConvert.DeserializeObject<SixDayForecastInfo.root>(json);            
                var DateTimeLabels = new Label[] { Date_0, Date_1, Date_2, Date_3, Date_4 };
                var IconPictureBoxes = new PictureBox[] { Icon_0, Icon_1, Icon_2, Icon_3, Icon_4 };
                var ConditionLabels = new Label[] { Condition_0, Condition_1, Condition_2, Condition_3, Condition_4 };
                var DetailsLabels = new Label[] { Details_0, Details_1, Details_2, Details_3, Details_4 };
                var TempLabels = new Label[] { Temp_0, Temp_1, Temp_2, Temp_3, Temp_4 };
                var TempMinLabels = new Label[] { TempMin_0, TempMin_1, TempMin_2, TempMin_3, TempMin_4 };
                var TempMaxLabels = new Label[] { TempMax_0, TempMax_1, TempMax_2, TempMax_3, TempMax_4 };

                for (int i = 0; i <= 4; i++)
                {
                    DateTimeLabels[i].Text = "WoW";
                    IconPictureBoxes[i].ImageLocation = "https://api.openweathermap.org/img/w/" + info.daily[i].weather[0].icon + ".png";
                }
            }
        }
    }
}