
using System.Drawing;

namespace WeatherServices
{
    partial class WeatherService
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherService));
            this.thermometer = new System.Windows.Forms.PictureBox();
            this.tempratureBar = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.colorBarFiller = new System.Windows.Forms.PictureBox();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.sunrise = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.sunset = new System.Windows.Forms.Label();
            this.labCondition = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.windSpeed = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.TimeOnSystem = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DateOnSystem = new System.Windows.Forms.Label();
            this.lbl_MaxTemp = new System.Windows.Forms.Label();
            this.temp_Max = new System.Windows.Forms.Label();
            this.OpenWeatherForecast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.temp_Min = new System.Windows.Forms.Label();
            this.lbl_ActualTemp = new System.Windows.Forms.Label();
            this.ActualTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thermometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempratureBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBarFiller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // thermometer
            // 
            this.thermometer.BackColor = System.Drawing.Color.Transparent;
            this.thermometer.Image = ((System.Drawing.Image)(resources.GetObject("thermometer.Image")));
            this.thermometer.Location = new System.Drawing.Point(12, 12);
            this.thermometer.Name = "thermometer";
            this.thermometer.Size = new System.Drawing.Size(284, 491);
            this.thermometer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thermometer.TabIndex = 1;
            this.thermometer.TabStop = false;
            // 
            // tempratureBar
            // 
            this.tempratureBar.BackColor = System.Drawing.Color.Transparent;
            this.tempratureBar.Image = ((System.Drawing.Image)(resources.GetObject("tempratureBar.Image")));
            this.tempratureBar.Location = new System.Drawing.Point(75, 62);
            this.tempratureBar.Name = "tempratureBar";
            this.tempratureBar.Size = new System.Drawing.Size(15, 421);
            this.tempratureBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tempratureBar.TabIndex = 2;
            this.tempratureBar.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(695, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 34);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // colorBarFiller
            // 
            this.colorBarFiller.Image = ((System.Drawing.Image)(resources.GetObject("colorBarFiller.Image")));
            this.colorBarFiller.Location = new System.Drawing.Point(75, 453);
            this.colorBarFiller.Name = "colorBarFiller";
            this.colorBarFiller.Size = new System.Drawing.Size(15, 30);
            this.colorBarFiller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorBarFiller.TabIndex = 4;
            this.colorBarFiller.TabStop = false;
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(378, 63);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(238, 34);
            this.TBCity.TabIndex = 5;
            this.TBCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBCity_KeyDown);
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.BackColor = System.Drawing.Color.Transparent;
            this.city.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.ForeColor = System.Drawing.Color.White;
            this.city.Location = new System.Drawing.Point(302, 63);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(63, 33);
            this.city.TabIndex = 6;
            this.city.Text = "City:";
            // 
            // sunrise
            // 
            this.sunrise.AutoSize = true;
            this.sunrise.BackColor = System.Drawing.Color.Transparent;
            this.sunrise.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunrise.ForeColor = System.Drawing.Color.White;
            this.sunrise.Location = new System.Drawing.Point(557, 118);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(91, 29);
            this.sunrise.TabIndex = 7;
            this.sunrise.Text = "Sunrise:";
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.BackColor = System.Drawing.Color.Transparent;
            this.pressure.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressure.ForeColor = System.Drawing.Color.White;
            this.pressure.Location = new System.Drawing.Point(557, 271);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(102, 29);
            this.pressure.TabIndex = 8;
            this.pressure.Text = "Pressure:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.Color.White;
            this.labSunrise.Location = new System.Drawing.Point(714, 118);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(51, 29);
            this.labSunrise.TabIndex = 9;
            this.labSunrise.Text = "N/A";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.ForeColor = System.Drawing.Color.White;
            this.labWindSpeed.Location = new System.Drawing.Point(714, 228);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(51, 29);
            this.labWindSpeed.TabIndex = 10;
            this.labWindSpeed.Text = "N/A";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.Color.White;
            this.labDetails.Location = new System.Drawing.Point(303, 253);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(81, 29);
            this.labDetails.TabIndex = 11;
            this.labDetails.Text = "Details";
            // 
            // sunset
            // 
            this.sunset.AutoSize = true;
            this.sunset.BackColor = System.Drawing.Color.Transparent;
            this.sunset.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunset.ForeColor = System.Drawing.Color.White;
            this.sunset.Location = new System.Drawing.Point(557, 158);
            this.sunset.Name = "sunset";
            this.sunset.Size = new System.Drawing.Size(85, 29);
            this.sunset.TabIndex = 12;
            this.sunset.Text = "Sunset:";
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.Color.White;
            this.labCondition.Location = new System.Drawing.Point(303, 210);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(110, 29);
            this.labCondition.TabIndex = 13;
            this.labCondition.Text = "Condition";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.Color.White;
            this.labSunset.Location = new System.Drawing.Point(714, 158);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(51, 29);
            this.labSunset.TabIndex = 14;
            this.labSunset.Text = "N/A";
            // 
            // windSpeed
            // 
            this.windSpeed.AutoSize = true;
            this.windSpeed.BackColor = System.Drawing.Color.Transparent;
            this.windSpeed.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeed.ForeColor = System.Drawing.Color.White;
            this.windSpeed.Location = new System.Drawing.Point(557, 228);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(138, 29);
            this.windSpeed.TabIndex = 15;
            this.windSpeed.Text = "Wind Speed:";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.Color.White;
            this.labPressure.Location = new System.Drawing.Point(714, 271);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(51, 29);
            this.labPressure.TabIndex = 16;
            this.labPressure.Text = "N/A";
            // 
            // TimeOnSystem
            // 
            this.TimeOnSystem.AutoSize = true;
            this.TimeOnSystem.BackColor = System.Drawing.Color.Transparent;
            this.TimeOnSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOnSystem.ForeColor = System.Drawing.Color.White;
            this.TimeOnSystem.Location = new System.Drawing.Point(730, 9);
            this.TimeOnSystem.Name = "TimeOnSystem";
            this.TimeOnSystem.Size = new System.Drawing.Size(96, 26);
            this.TimeOnSystem.TabIndex = 17;
            this.TimeOnSystem.Text = "00:00:00";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIcon.Location = new System.Drawing.Point(308, 113);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(123, 87);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 18;
            this.picIcon.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DateOnSystem
            // 
            this.DateOnSystem.AutoSize = true;
            this.DateOnSystem.BackColor = System.Drawing.Color.Transparent;
            this.DateOnSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOnSystem.ForeColor = System.Drawing.Color.White;
            this.DateOnSystem.Location = new System.Drawing.Point(600, 9);
            this.DateOnSystem.Name = "DateOnSystem";
            this.DateOnSystem.Size = new System.Drawing.Size(124, 26);
            this.DateOnSystem.TabIndex = 19;
            this.DateOnSystem.Text = "DD:MM:YY";
            // 
            // lbl_MaxTemp
            // 
            this.lbl_MaxTemp.AutoSize = true;
            this.lbl_MaxTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MaxTemp.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaxTemp.ForeColor = System.Drawing.Color.White;
            this.lbl_MaxTemp.Location = new System.Drawing.Point(557, 308);
            this.lbl_MaxTemp.Name = "lbl_MaxTemp";
            this.lbl_MaxTemp.Size = new System.Drawing.Size(127, 29);
            this.lbl_MaxTemp.TabIndex = 20;
            this.lbl_MaxTemp.Text = "Max Temp.:";
            // 
            // temp_Max
            // 
            this.temp_Max.AutoSize = true;
            this.temp_Max.BackColor = System.Drawing.Color.Transparent;
            this.temp_Max.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_Max.ForeColor = System.Drawing.Color.White;
            this.temp_Max.Location = new System.Drawing.Point(714, 308);
            this.temp_Max.Name = "temp_Max";
            this.temp_Max.Size = new System.Drawing.Size(51, 29);
            this.temp_Max.TabIndex = 21;
            this.temp_Max.Text = "N/A";
            // 
            // OpenWeatherForecast
            // 
            this.OpenWeatherForecast.BackColor = System.Drawing.Color.White;
            this.OpenWeatherForecast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenWeatherForecast.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenWeatherForecast.ForeColor = System.Drawing.Color.Black;
            this.OpenWeatherForecast.Location = new System.Drawing.Point(667, 515);
            this.OpenWeatherForecast.Name = "OpenWeatherForecast";
            this.OpenWeatherForecast.Size = new System.Drawing.Size(159, 34);
            this.OpenWeatherForecast.TabIndex = 22;
            this.OpenWeatherForecast.Text = "6-Day-Forecast";
            this.OpenWeatherForecast.UseVisualStyleBackColor = false;
            this.OpenWeatherForecast.Click += new System.EventHandler(this.OpenWeatherForecast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(557, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Min Temp.:";
            // 
            // temp_Min
            // 
            this.temp_Min.AutoSize = true;
            this.temp_Min.BackColor = System.Drawing.Color.Transparent;
            this.temp_Min.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_Min.ForeColor = System.Drawing.Color.White;
            this.temp_Min.Location = new System.Drawing.Point(714, 348);
            this.temp_Min.Name = "temp_Min";
            this.temp_Min.Size = new System.Drawing.Size(51, 29);
            this.temp_Min.TabIndex = 24;
            this.temp_Min.Text = "N/A";
            // 
            // lbl_ActualTemp
            // 
            this.lbl_ActualTemp.AutoSize = true;
            this.lbl_ActualTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ActualTemp.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ActualTemp.ForeColor = System.Drawing.Color.White;
            this.lbl_ActualTemp.Location = new System.Drawing.Point(557, 189);
            this.lbl_ActualTemp.Name = "lbl_ActualTemp";
            this.lbl_ActualTemp.Size = new System.Drawing.Size(79, 29);
            this.lbl_ActualTemp.TabIndex = 25;
            this.lbl_ActualTemp.Text = "Temp.:";
            // 
            // ActualTemp
            // 
            this.ActualTemp.AutoSize = true;
            this.ActualTemp.BackColor = System.Drawing.Color.Transparent;
            this.ActualTemp.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualTemp.ForeColor = System.Drawing.Color.White;
            this.ActualTemp.Location = new System.Drawing.Point(714, 189);
            this.ActualTemp.Name = "ActualTemp";
            this.ActualTemp.Size = new System.Drawing.Size(51, 29);
            this.ActualTemp.TabIndex = 26;
            this.ActualTemp.Text = "N/A";
            // 
            // WeatherService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(838, 561);
            this.Controls.Add(this.ActualTemp);
            this.Controls.Add(this.lbl_ActualTemp);
            this.Controls.Add(this.temp_Min);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenWeatherForecast);
            this.Controls.Add(this.temp_Max);
            this.Controls.Add(this.lbl_MaxTemp);
            this.Controls.Add(this.DateOnSystem);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.TimeOnSystem);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.windSpeed);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.sunset);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.city);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.colorBarFiller);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tempratureBar);
            this.Controls.Add(this.thermometer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeatherService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Service";
            this.LocationChanged += new System.EventHandler(this.WeatherService_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.thermometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempratureBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBarFiller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox thermometer;
        private System.Windows.Forms.PictureBox tempratureBar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox colorBarFiller;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label sunrise;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label sunset;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label windSpeed;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label TimeOnSystem;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label DateOnSystem;
        private System.Windows.Forms.Label lbl_MaxTemp;
        private System.Windows.Forms.Label temp_Max;
        private System.Windows.Forms.Button OpenWeatherForecast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label temp_Min;
        private System.Windows.Forms.Label lbl_ActualTemp;
        private System.Windows.Forms.Label ActualTemp;
    }
}

