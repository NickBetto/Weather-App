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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            DisplayForecast();
        }

        public void DisplayForecast()
        {
            double High = Convert.ToDouble(Form1.days[1].tempHigh);
            double High1 = Convert.ToDouble(Form1.days[2].tempHigh);
            double High2 = Convert.ToDouble(Form1.days[3].tempHigh);
            double High3 = Convert.ToDouble(Form1.days[4].tempHigh);
            double High4 = Convert.ToDouble(Form1.days[5].tempHigh);
            double High5 = Convert.ToDouble(Form1.days[6].tempHigh);
            double Low = Convert.ToDouble(Form1.days[1].tempLow);
            double Low1 = Convert.ToDouble(Form1.days[2].tempLow);
            double Low2 = Convert.ToDouble(Form1.days[3].tempLow);
            double Low3 = Convert.ToDouble(Form1.days[4].tempLow);
            double Low4 = Convert.ToDouble(Form1.days[5].tempLow);
            double Low5 = Convert.ToDouble(Form1.days[6].tempLow);

            day1Label.Text = DateTime.Now.AddDays(0).DayOfWeek.ToString();
            day2Label.Text = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            day3Label.Text = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            day4Label.Text = DateTime.Now.AddDays(3).DayOfWeek.ToString();
            day5Label.Text = DateTime.Now.AddDays(4).DayOfWeek.ToString();
            day6Label.Text = DateTime.Now.AddDays(5).DayOfWeek.ToString();

            day1HighLabel.Text = High.ToString("0°");
            day2HighLabel.Text = High1.ToString("0°");
            day3HighLabel.Text = High2.ToString("0°");
            day4HighLabel.Text = High3.ToString("0°");
            day5HighLabel.Text = High4.ToString("0°");
            day6HighLabel.Text = High5.ToString("0°");
            day1LowLabel.Text = Low.ToString("0°");
            day2LowLabel.Text = Low1.ToString("0°");
            day3LowLabel.Text = Low2.ToString("0°");
            day4LowLabel.Text = Low3.ToString("0°");
            day5LowLabel.Text = Low4.ToString("0°");
            day6LowLabel.Text = Low5.ToString("0°");

            int condition;
            condition = Convert.ToInt32(Form1.days[1].condition);
            if (condition >= 200 && condition <= 232)
            {
                day1Condition.Image = Properties.Resources.Thunderstorm;
            }
            else if (condition >= 300 && condition <= 321)
            {
                day1Condition.Image = Properties.Resources.Drizzle;
            }
            else if (condition >= 500 && condition <= 531)
            {
                day1Condition.Image = Properties.Resources.Rain;
            }
            else if (condition >= 600 && condition <= 622)
            {
                day1Condition.Image = Properties.Resources.Snow;
            }
            else if (condition >= 700 && condition <= 781)
            {
                day1Condition.Image = Properties.Resources.Fog;
            }
            else if (condition == 800)
            {
                day1Condition.Image = Properties.Resources.Sunny;
            }
            else if (condition >= 801 && condition <= 804)
            {
                day1Condition.Image = Properties.Resources.Clouds;
            }
            int condition1;
            condition1 = Convert.ToInt32(Form1.days[2].condition);
            if (condition1 >= 200 && condition1 <= 232)
            {
                day2Condition.Image = Properties.Resources.Thunderstorm;
            }
            else if (condition1 >= 300 && condition1 <= 321)
            {
                day2Condition.Image = Properties.Resources.Drizzle;
            }
            else if (condition1 >= 500 && condition1 <= 531)
            {
                day2Condition.Image = Properties.Resources.Rain;
            }
            else if (condition1 >= 600 && condition1 <= 622)
            {
                day2Condition.Image = Properties.Resources.Snow;
            }
            else if (condition1 >= 700 && condition1 <= 781)
            {
                day2Condition.Image = Properties.Resources.Fog;
            }
            else if (condition1 == 800)
            {
                day2Condition.Image = Properties.Resources.Sunny;
            }
            else if (condition1 >= 801 && condition1 <= 804)
            {
                day2Condition.Image = Properties.Resources.Clouds;
            }
            int condition2;
            condition2 = Convert.ToInt32(Form1.days[3].condition);
            if (condition2 >= 200 && condition2 <= 232)
            {
                day3Condition.Image = Properties.Resources.Thunderstorm;
            }
            else if (condition2 >= 300 && condition2 <= 321)
            {
                day3Condition.Image = Properties.Resources.Drizzle;
            }
            else if (condition2 >= 500 && condition2 <= 531)
            {
                day3Condition.Image = Properties.Resources.Rain;
            }
            else if (condition2 >= 600 && condition2 <= 622)
            {
                day3Condition.Image = Properties.Resources.Snow;
            }
            else if (condition2 >= 700 && condition2 <= 781)
            {
                day3Condition.Image = Properties.Resources.Fog;
            }
            else if (condition2 == 800)
            {
                day3Condition.Image = Properties.Resources.Sunny;
            }
            else if (condition2 >= 801 && condition2 <= 804)
            {
                day3Condition.Image = Properties.Resources.Clouds;
            }
            int condition3;
            condition3 = Convert.ToInt32(Form1.days[4].condition);
            if (condition3 >= 200 && condition3 <= 232)
            {
                day4Condition.Image = Properties.Resources.Thunderstorm;
            }
            else if (condition3 >= 300 && condition3 <= 321)
            {
                day4Condition.Image = Properties.Resources.Drizzle;
            }
            else if (condition3 >= 500 && condition3 <= 531)
            {
                day4Condition.Image = Properties.Resources.Rain;
            }
            else if (condition3 >= 600 && condition3 <= 622)
            {
                day4Condition.Image = Properties.Resources.Snow;
            }
            else if (condition3 >= 700 && condition3 <= 781)
            {
                day4Condition.Image = Properties.Resources.Fog;
            }
            else if (condition3 == 800)
            {
                day4Condition.Image = Properties.Resources.Sunny;
            }
            else if (condition3 >= 801 && condition3 <= 804)
            {
                day4Condition.Image = Properties.Resources.Clouds;
            }
            int condition4;
            condition4 = Convert.ToInt32(Form1.days[5].condition);
            if (condition4 >= 200 && condition4 <= 232)
            {
                day5Condition.Image = Properties.Resources.Thunderstorm;
            }
            else if (condition4 >= 300 && condition4 <= 321)
            {
                day5Condition.Image = Properties.Resources.Drizzle;
            }
            else if (condition4 >= 500 && condition4 <= 531)
            {
                day5Condition.Image = Properties.Resources.Rain;
            }
            else if (condition4 >= 600 && condition4 <= 622)
            {
                day5Condition.Image = Properties.Resources.Snow;
            }
            else if (condition4 >= 700 && condition4 <= 781)
            {
                day5Condition.Image = Properties.Resources.Fog;
            }
            else if (condition4 == 800)
            {
                day5Condition.Image = Properties.Resources.Sunny;
            }
            else if (condition4 >= 801 && condition4 <= 804)
            {
                day5Condition.Image = Properties.Resources.Clouds;
            }
            int condition5;
            condition5 = Convert.ToInt32(Form1.days[6].condition);
            if (condition5 >= 200 && condition5 <= 232)
            {
                day6Condition.Image = Properties.Resources.Thunderstorm;
            }
            else if (condition5 >= 300 && condition5 <= 321)
            {
                day6Condition.Image = Properties.Resources.Drizzle;
            }
            else if (condition5 >= 500 && condition5 <= 531)
            {
                day6Condition.Image = Properties.Resources.Rain;
            }
            else if (condition5 >= 600 && condition5 <= 622)
            {
                day6Condition.Image = Properties.Resources.Snow;
            }
            else if (condition5 >= 700 && condition5 <= 781)
            {
                day6Condition.Image = Properties.Resources.Fog;
            }
            else if (condition5 == 800)
            {
                day6Condition.Image = Properties.Resources.Sunny;
            }
            else if (condition5 >= 801 && condition5 <= 804)
            {
                day6Condition.Image = Properties.Resources.Clouds;
            }
        }

        private void dailyLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            DailyScreen ds = new DailyScreen();
            f.Controls.Add(ds);
            ds.Focus();
        }
    }
}
