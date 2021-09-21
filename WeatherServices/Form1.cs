using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp = -10;
            int heightGrowth = (temp+20) * 6;
            thermometer.Controls.Add(tempratureBar);
            tempratureBar.Height = heightGrowth;
            tempratureBar.Location = new Point(63, 472-heightGrowth);
            tempratureBar.BackColor = Color.Transparent;
            if(temp > 0)
            {
                colorBarFiller.Height = 30;
                colorBarFiller.Location = new Point(63, 442);
                colorBarFiller.BackColor = Color.Transparent;
            }
        }
    }
}
