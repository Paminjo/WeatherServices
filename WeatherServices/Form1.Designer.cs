
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
            this.button1 = new System.Windows.Forms.Button();
            this.colorBarFiller = new System.Windows.Forms.PictureBox();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // WeatherService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.colorBarFiller);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tempratureBar);
            this.Controls.Add(this.thermometer);
            this.Name = "WeatherService";
            this.Text = "Weather Service";
            ((System.ComponentModel.ISupportInitialize)(this.thermometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempratureBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBarFiller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox thermometer;
        private System.Windows.Forms.PictureBox tempratureBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox colorBarFiller;
    }
}

