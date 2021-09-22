
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
            this.searchRegion = new System.Windows.Forms.Button();
            this.colorBarFiller = new System.Windows.Forms.PictureBox();
            this.stadtnamenEingabe = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.sunrise = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.sunriseTime = new System.Windows.Forms.Label();
            this.windSpeedValue = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.Label();
            this.sunset = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.Label();
            this.sunsetTime = new System.Windows.Forms.Label();
            this.windSpeed = new System.Windows.Forms.Label();
            this.pressureValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thermometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempratureBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBarFiller)).BeginInit();
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
            this.thermometer.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.tempratureBar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // searchRegion
            // 
            this.searchRegion.Location = new System.Drawing.Point(676, 61);
            this.searchRegion.Name = "searchRegion";
            this.searchRegion.Size = new System.Drawing.Size(75, 31);
            this.searchRegion.TabIndex = 3;
            this.searchRegion.Text = "Search";
            this.searchRegion.UseVisualStyleBackColor = true;
            this.searchRegion.Click += new System.EventHandler(this.button1_Click);
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
            // stadtnamenEingabe
            // 
            this.stadtnamenEingabe.Location = new System.Drawing.Point(413, 61);
            this.stadtnamenEingabe.Multiline = true;
            this.stadtnamenEingabe.Name = "stadtnamenEingabe";
            this.stadtnamenEingabe.Size = new System.Drawing.Size(238, 31);
            this.stadtnamenEingabe.TabIndex = 5;
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(337, 61);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(70, 31);
            this.city.TabIndex = 6;
            this.city.Text = "City:";
            // 
            // sunrise
            // 
            this.sunrise.AutoSize = true;
            this.sunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunrise.Location = new System.Drawing.Point(338, 324);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(92, 26);
            this.sunrise.TabIndex = 7;
            this.sunrise.Text = "Sunrise:";
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressure.Location = new System.Drawing.Point(548, 236);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(99, 26);
            this.pressure.TabIndex = 8;
            this.pressure.Text = "Pressure";
            // 
            // sunriseTime
            // 
            this.sunriseTime.AutoSize = true;
            this.sunriseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunriseTime.Location = new System.Drawing.Point(436, 324);
            this.sunriseTime.Name = "sunriseTime";
            this.sunriseTime.Size = new System.Drawing.Size(49, 26);
            this.sunriseTime.TabIndex = 9;
            this.sunriseTime.Text = "N/A";
            // 
            // windSpeedValue
            // 
            this.windSpeedValue.AutoSize = true;
            this.windSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeedValue.Location = new System.Drawing.Point(702, 186);
            this.windSpeedValue.Name = "windSpeedValue";
            this.windSpeedValue.Size = new System.Drawing.Size(49, 26);
            this.windSpeedValue.TabIndex = 10;
            this.windSpeedValue.Text = "N/A";
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.Location = new System.Drawing.Point(338, 236);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(79, 26);
            this.details.TabIndex = 11;
            this.details.Text = "Details";
            this.details.Click += new System.EventHandler(this.label5_Click);
            // 
            // sunset
            // 
            this.sunset.AutoSize = true;
            this.sunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunset.Location = new System.Drawing.Point(338, 368);
            this.sunset.Name = "sunset";
            this.sunset.Size = new System.Drawing.Size(86, 26);
            this.sunset.TabIndex = 12;
            this.sunset.Text = "Sunset:";
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition.Location = new System.Drawing.Point(338, 186);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(104, 26);
            this.condition.TabIndex = 13;
            this.condition.Text = "Condition";
            this.condition.Click += new System.EventHandler(this.label7_Click);
            // 
            // sunsetTime
            // 
            this.sunsetTime.AutoSize = true;
            this.sunsetTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunsetTime.Location = new System.Drawing.Point(436, 368);
            this.sunsetTime.Name = "sunsetTime";
            this.sunsetTime.Size = new System.Drawing.Size(49, 26);
            this.sunsetTime.TabIndex = 14;
            this.sunsetTime.Text = "N/A";
            // 
            // windSpeed
            // 
            this.windSpeed.AutoSize = true;
            this.windSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeed.Location = new System.Drawing.Point(548, 186);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(131, 26);
            this.windSpeed.TabIndex = 15;
            this.windSpeed.Text = "Wind Speed";
            // 
            // pressureValue
            // 
            this.pressureValue.AutoSize = true;
            this.pressureValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureValue.Location = new System.Drawing.Point(702, 236);
            this.pressureValue.Name = "pressureValue";
            this.pressureValue.Size = new System.Drawing.Size(49, 26);
            this.pressureValue.TabIndex = 16;
            this.pressureValue.Text = "N/A";
            // 
            // WeatherService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 515);
            this.Controls.Add(this.pressureValue);
            this.Controls.Add(this.windSpeed);
            this.Controls.Add(this.sunsetTime);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.sunset);
            this.Controls.Add(this.details);
            this.Controls.Add(this.windSpeedValue);
            this.Controls.Add(this.sunriseTime);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.city);
            this.Controls.Add(this.stadtnamenEingabe);
            this.Controls.Add(this.colorBarFiller);
            this.Controls.Add(this.searchRegion);
            this.Controls.Add(this.tempratureBar);
            this.Controls.Add(this.thermometer);
            this.Name = "WeatherService";
            this.Text = "Weather Service";
            ((System.ComponentModel.ISupportInitialize)(this.thermometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempratureBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBarFiller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox thermometer;
        private System.Windows.Forms.PictureBox tempratureBar;
        private System.Windows.Forms.Button searchRegion;
        private System.Windows.Forms.PictureBox colorBarFiller;
        private System.Windows.Forms.TextBox stadtnamenEingabe;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label sunrise;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label sunriseTime;
        private System.Windows.Forms.Label windSpeedValue;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.Label sunset;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Label sunsetTime;
        private System.Windows.Forms.Label windSpeed;
        private System.Windows.Forms.Label pressureValue;
    }
}

