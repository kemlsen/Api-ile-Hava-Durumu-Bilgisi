using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HavaDurumuAPII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString();
            string api = "8de6a8b337480d03d6c742d865e4abd3";
            string con = "https://api.openweathermap.org/data/2.5/weather?q=izmir&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument hava = XDocument.Load(con);
            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;        
            label4.Text=sicaklik.ToString();
        }
    }
}
