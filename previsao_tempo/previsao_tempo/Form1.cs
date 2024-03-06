﻿using Newtonsoft.Json;
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
using Newtonsoft.Json;
using System.Net;

namespace previsao_tempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string chaveAPI = "d0c4d691e3f1fa2da4267474044805d3";

        private void cbxCdds_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            getWeather();

        }

        void getWeather()
        {


            using (WebClient web = new WebClient())
            {

                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&lang=pt_br&units=metric&appid={1}", cbxCdds.Text, chaveAPI);

                var json = web.DownloadString(url);

                ClimaInfo.root info = JsonConvert.DeserializeObject<ClimaInfo.root>(json);

                cidadeNome.Text = info.name;
                temperatura.Text = info.main.temp.ToString();
                sensacao.Text = info.main.feels_like.ToString();
                minima.Text = info.main.temp_min.ToString();
                maxima.Text = info.main.temp_max.ToString();

            }

        }
    }
}