
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
            this.Date = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
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
            this.btnSearch.Location = new System.Drawing.Point(683, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 31);
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
            this.TBCity.Location = new System.Drawing.Point(420, 101);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(238, 34);
            this.TBCity.TabIndex = 5;
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.BackColor = System.Drawing.Color.Transparent;
            this.city.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.ForeColor = System.Drawing.Color.White;
            this.city.Location = new System.Drawing.Point(344, 101);
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
            this.sunrise.Location = new System.Drawing.Point(345, 313);
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
            this.pressure.Location = new System.Drawing.Point(569, 272);
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
            this.labSunrise.Location = new System.Drawing.Point(461, 313);
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
            this.labWindSpeed.Location = new System.Drawing.Point(708, 230);
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
            this.labDetails.Location = new System.Drawing.Point(345, 272);
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
            this.sunset.Location = new System.Drawing.Point(427, 381);
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
            this.labCondition.Location = new System.Drawing.Point(345, 231);
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
            this.labSunset.Location = new System.Drawing.Point(566, 381);
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
            this.windSpeed.Location = new System.Drawing.Point(569, 230);
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
            this.labPressure.Location = new System.Drawing.Point(708, 272);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(51, 29);
            this.labPressure.TabIndex = 16;
            this.labPressure.Text = "N/A";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.BackColor = System.Drawing.Color.Transparent;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(730, 9);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(96, 26);
            this.Date.TabIndex = 17;
            this.Date.Text = "00:00:00";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIcon.Location = new System.Drawing.Point(350, 141);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(123, 87);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 18;
            this.picIcon.TabStop = false;
            // 
            // WeatherService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(838, 515);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.Date);
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
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.PictureBox picIcon;
    }
}

