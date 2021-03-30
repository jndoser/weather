using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHoangLong_5951071052_Weather
{
    public partial class Form1 : Form
    {
        const string APPID = "7e66e43a50ca15fdf9d08903a9ceca5e";
        string cityID = "1566083";
        public Form1()
        {
            InitializeComponent();
            getWeather(cityID);
            getWeather(cityID);
        }

        private void getWeather(string cituID)
        {
            using(WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?id={0}&appid={1}&units=metric&cnt=6", cityID, APPID);

                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                WeatherInfo.root ouPut = result;

                lbl_textCity.Text = string.Format("{0}", ouPut.name);
                lbl_Country.Text = string.Format("{0}", ouPut.sys.country);
                lbl_DoCe.Text = string.Format("{0} \u00B0" + "C", ouPut.main.temp);
            }
        }

        void getForcast(string city)
        {
            int day = 2;
            string url = string.Format("https://api.openweathermap.org/data/2.5/forecast/daily?id={0}&units=metric&cnt={1}&appid={2}", cityID, day, APPID);
            using (WebClient web = new WebClient())
            {          
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherForecasts>(json);
                WeatherForecasts forecasts = result;

                lbl_Condition.Text = string.Format("{0}", forecasts.list[1].weather[0].main);
                lblDes.Text = string.Format("{0}", forecasts.list[1].weather[0].descriptions);
                lbl_Des2.Text = string.Format("{0} \u00B0" + "C", forecasts.list[1].temp);
                lbl_Speed.Text = string.Format("{0}", forecasts.list[1].speed);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
