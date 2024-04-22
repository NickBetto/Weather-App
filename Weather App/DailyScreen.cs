using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_App
{
    public partial class DailyScreen : UserControl
    {
        public DailyScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            double current = Convert.ToDouble(Form1.days[0].currentTemp);
            double high = Convert.ToDouble(Form1.days[0].tempHigh);
            double low = Convert.ToDouble(Form1.days[0].tempLow);
            double chance = Convert.ToDouble(Form1.days[0].precipitation);

            dateLabel.Text = Form1.days[0].date;
            tempLabel.Text = current.ToString("0°");
            speedLabel.Text = $"{Form1.days[0].windSpeed} mps";
            highLowLabel.Text = $"{high.ToString("0°")} / {low.ToString("0°")}";
            chanceLabel.Text = chance.ToString("0%");

            int condition;
            condition = Convert.ToInt32(Form1.days[0].condition);
            if (condition >= 200 && condition <= 232)
            {
                conditionLabel.Text = "Thunderstorm";
                rainLabel.Text = "Heavy Rain";
                conditionImage.Image = Properties.Resources.Thunderstorm;
                this.BackColor = Color.Gray;
            }
            else if (condition >= 300 && condition <= 321)
            {
                conditionLabel.Text = "Drizzle";
                rainLabel.Text = "Steady";
                conditionImage.Image = Properties.Resources.Drizzle;
                this.BackColor = Color.DarkSeaGreen;
            }
            else if (condition >= 500 && condition <= 531)
            {
                conditionLabel.Text = "Rain";
                rainLabel.Text = "Moderate";
                conditionImage.Image = Properties.Resources.Rain;
                this.BackColor = Color.DarkGray;
            }
            else if (condition >= 600 && condition <= 622)
            {
                conditionLabel.Text = "Snow";
                rainLabel.Text = "Frozen";
                conditionImage.Image = Properties.Resources.Snow;
                this.BackColor = Color.WhiteSmoke;
            }
            else if (condition >= 700 && condition <= 781)
            {
                conditionLabel.Text = "Atmosphere";
                rainLabel.Text = "None";
                conditionImage.Image = Properties.Resources.Fog;
                this.BackColor = Color.Gainsboro;
            }
            else if (condition == 800)
            {
                conditionLabel.Text = "Clear";
                rainLabel.Text = "None";
                conditionImage.Image = Properties.Resources.Sunny;
            }
            else if (condition >= 801 && condition <= 804)
            {
                conditionLabel.Text = "Clouds";
                rainLabel.Text = "None";
                conditionImage.Image = Properties.Resources.Clouds;
            }

        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
            fs.Focus();
        }
    }
}
