using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Weather_App
{
    public partial class Form1 : Form
    {
        public static List<Day> days = new List<Day>();
        public Form1()
        {
            InitializeComponent();
            ExtractForecast();

            DailyScreen ds = new DailyScreen();
            this.Controls.Add(ds);
        }

        private void ExtractForecast()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                Day d = new Day();

                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                d.condition = reader.GetAttribute("number");

                reader.ReadToFollowing("precipitation");
                d.precipitation = reader.GetAttribute("probability");

                reader.ReadToFollowing("windDirection");
                d.windDirection = reader.GetAttribute("name");

                reader.ReadToFollowing("windSpeed");
                d.windSpeed = reader.GetAttribute("mps");

                reader.ReadToFollowing("temperature");
                d.currentTemp = reader.GetAttribute("day");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                days.Add(d);
            }
            days[0].condition = "300";
        }
    }
}
