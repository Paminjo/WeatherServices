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

        // Objekt für die Methoden und stuff den beide Forms benötigen
        private WeatherRequest weatherRequest = new WeatherRequest();

        // Öffentliche Werte für das Main-Form zum überprüfen und aggieren
        public bool checkWeatherForecast = false;
        public string cityName = "";
        public double lat { get; set; }
        public double lon { get; set; }
        public bool backToWeatherToday { get; set; }
        public bool weatherForecastClosed { get; set; }
        public char gotBack = 'n';

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await GetRequestData();
        }


        private async Task GetRequestData()
        {
            try
            {
                // Die Tages Abfrage, für lat lon (Man könnte es auch ohne 2-Aufrufe machen, aber das kostet 35$ im Monat..)
                var weatherToday = await weatherRequest.GetWeatherToday(TBCity.Text);
                cityName = TBCity.Text;
                lat = weatherToday.coord.lat;
                lon = weatherToday.coord.lon;
                // Mit Lat und Lon werden ím Objekt geändert
                weatherRequest.SetLatLon(weatherToday.coord.lat, weatherToday.coord.lon);
                // Wettervorhersagedaten werden abgerufen
                await GetWeatherForecastData();
            }
            catch (WebException webEx)
            {
                MessageBox.Show(Convert.ToString(webEx));
            }
        }

        // Holt Daten -> Setzt Arrays -> mit for in Arrays Daten einsetzen
        private async Task GetWeatherForecastData() 
        {
            // Mögliche Fehler abfangen
            try 
            {   
                // Holt sich von der Klasse WeatherRequest das Objekt
                var Info = await weatherRequest.GetWeatherForecast(); 
                
                // Array erstellungen für einfachere Handhabung, wird nach Anwendung gemillt
                var DateTimeLabels = new Label[] { Date_0, Date_1, Date_2, Date_3, Date_4, Date_5 }; 
                var IconPictureBoxes = new PictureBox[] { Icon_0, Icon_1, Icon_2, Icon_3, Icon_4, Icon_5 };
                var TempLabels = new Label[] { ValueTemp_0, ValueTemp_1, ValueTemp_2, ValueTemp_3, ValueTemp_4, ValueTemp_5 };
                var TempMinLabels = new Label[] { ValueMinTemp_0, ValueMinTemp_1, ValueMinTemp_2, ValueMinTemp_3, ValueMinTemp_4, ValueMinTemp_5 };
                var TempMaxLabels = new Label[] { ValueMaxTemp_0, ValueMaxTemp_1, ValueMaxTemp_2, ValueMaxTemp_3, ValueMaxTemp_4, ValueMaxTemp_5 };

                double maxTemp = -200;
                double minTemp = 200;
                double avgTemp = 0;
                
                // Eingabe der Daten in die Label.Text Arrays
                for (int i = 0; i <= 5; i++) 
                {
                    DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    DateTimeLabels[i].Text = day.AddSeconds(Info.daily[i].dt).ToShortDateString();
                    TempMinLabels[i].Text = Convert.ToString(Info.daily[i].temp.min + "°C");
                    TempMaxLabels[i].Text = Convert.ToString(Info.daily[i].temp.max + "°C");
                    TempLabels[i].Text = Convert.ToString(Math.Round((Info.daily[i].temp.min + Info.daily[i].temp.max) / 2, 2)) + "°C";
                    IconPictureBoxes[i].ImageLocation = "https://api.openweathermap.org/img/w/" + Info.daily[i].weather[0].icon + ".png";
                }

                // Wochen- durchschnit, -max, -min Temperature werden gesetzt
                for (int i = 0; i <= 6; i++) 
                {     
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

                avgTemp /= 7;

                // Wochendaten werden eingesetzt
                ValueAvgWeekTemp.Text = Convert.ToString(Math.Round(avgTemp, 2)) + "°C";
                ValueMaxWeekTemp.Text = Convert.ToString(maxTemp) + "°C";
                ValueMinWeekTemp.Text = Convert.ToString(minTemp) + "°C";
            }

            //Fehlermeldung wird Ausgegeben
            catch (WebException webEx)
            {
                MessageBox.Show(Convert.ToString(webEx));
            }
        }

        // Durch das Main-Form wird in dieser die City und Lat sowie Lon gesetzt
        public async void GetFirstRequestForWeatherForecast(double lat, double lon, string city)
        {
            weatherRequest.SetLatLon(lat, lon);
            TBCity.Text = city;
            await GetWeatherForecastData();
        }

        // Die 2 bool werte werden verändert, welche vom Main-Form überprüft werden
        private void back_Click(object sender, EventArgs e)
        {
            backToWeatherToday = true;
            checkWeatherForecast = false;
            gotBack = 'y';
        }

        // Wenn das Form geschlossen wird soll das Main-Form auch schließen
        private void WeatherForecast_FormClosed(object sender, FormClosedEventArgs e)
        {
            weatherForecastClosed = true;
        }

        // Enter Taste zum bestätigen der Stadt
        private async void TBCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await GetRequestData();
            }
        }
    }
}