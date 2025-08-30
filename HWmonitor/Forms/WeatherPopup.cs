using HWmonitor.Helpers;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace HWmonitor.Forms
{
    public partial class WeatherPopup : Form
    {
        private XmlDocument _document;
        private int hourPanelWidth = 70;
        private int padding = 5;
        private int headerLabelHeight = 15;
        private int labelHeight = 13;
        private int weatherPictureHeight = 40;
        private int scrollPadding = 20;
        private int maxHourlyHours = 7;
        public WeatherPopup()
        {
            InitializeComponent();
        }

        public void SetWeatherData(XmlDocument data)
        {
            _document = data;

            FillTodayData();
            FillDailyData();
            FillHourlyData();
        }

        private Panel CreatePeriodPanel(string time, string code, string precipitation, string temp, string wind, Point location)
        {
            Panel hourPanel = new Panel();
            hourPanel.Width = hourPanelWidth;
            hourPanel.Height = panelHourly.Height - scrollPadding;
            hourPanel.Location = location;
            
            hourPanel.Controls.Add(CreatePanelLabel(time, true, hourPanelWidth, headerLabelHeight, new Point(0, 0)));

            int picPositionY = headerLabelHeight + padding;
            hourPanel.Controls.Add(CreatePanelWeatherPicture(code, hourPanelWidth, weatherPictureHeight, new Point(0, picPositionY)));

            int precipitationLabelPosY = picPositionY + weatherPictureHeight + padding;
            hourPanel.Controls.Add(CreatePanelLabel(precipitation, false, hourPanelWidth, labelHeight, new Point(0, precipitationLabelPosY)));

            int tempLabelPosY = precipitationLabelPosY + labelHeight + (padding * 3);
            hourPanel.Controls.Add(CreatePanelLabel(temp, false, hourPanelWidth, labelHeight, new Point(0, tempLabelPosY)));

            int windLabelPosY = tempLabelPosY + labelHeight + padding;
            hourPanel.Controls.Add(CreatePanelLabel(wind, false, hourPanelWidth, labelHeight, new Point(0, windLabelPosY)));

            return hourPanel;
        }

        private Label CreatePanelLabel(string text, bool isHeader, int width, int height, Point location)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Font = new Font("Microsoft Sans Serif", isHeader ? 10 : 8, isHeader ? FontStyle.Bold : FontStyle.Regular);
            lbl.ForeColor = Color.White;
            lbl.Location = location;
            lbl.Width = width;
            lbl.Height = height;
            lbl.TextAlign = ContentAlignment.MiddleCenter;

            return lbl;
        }

        private PictureBox CreatePanelWeatherPicture(string code, int width, int height, Point location)
        { 
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = location;
            pictureBox.Width = width;
            pictureBox.Height = height;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            try
            {
                pictureBox.Image = WeatherIconHelper.GetWeatherIcon(Int32.Parse(code));
            } catch 
            {
                pictureBox.Image = Properties.Resources.sunny;
            }
            

            return pictureBox;
        }

        private string GetXmlValueByPath(string path)
        {
            XmlNodeList xnList = _document.SelectNodes(path);
            string val = "";

            foreach (XmlNode xn in xnList)
            {
                val = xn.InnerText;
            }

            return val;
        }

        private void FillTodayData()
        {
            string city = GetXmlValueByPath("/root/location/name");
            string country = GetXmlValueByPath("/root/location/country");
            label1.Text = city + ", " + country;

            temperature.Text = GetXmlValueByPath("/root/current/temp_c") + " °C";
            feelsLike.Text = GetXmlValueByPath("/root/current/feelslike_c") + " °C";

            string weatherCode = GetXmlValueByPath("/root/current/condition/code");
            weatherImage.Image = WeatherIconHelper.GetWeatherIcon(Int32.Parse(weatherCode));

            string windSpd = GetXmlValueByPath("/root/current/wind_kph");
            string windDir = GetXmlValueByPath("/root/current/wind_dir");
            wind.Text = windSpd + " km/h " + windDir;

            pressure.Text = GetXmlValueByPath("/root/current/pressure_mb") + " hPa";

            precipitation.Text = GetXmlValueByPath("/root/current/precip_mm") + " mm";
            humidity.Text = GetXmlValueByPath("/root/current/humidity") + "%";
        }

        private void FillDailyData()
        {
            XmlNodeList xnList = _document.SelectNodes("/root/forecast/forecastday");
            int day = 1;

            foreach (XmlNode xn in xnList)
            {
                FillDataForADay(day, xn);
                day++;
            }
        }

        private void FillDataForADay(int day, XmlNode data)
        {
            if (day == 1) 
            {
                DateTime d = DateTime.Parse(data.SelectSingleNode("date").InnerText);
                dayOneDate.Text = d.ToString("dd.MM.yyyy");
                dayOneHigh.Text = "H: " + data.SelectSingleNode("day/maxtemp_c").InnerText + " °C";
                dayOneLow.Text = "L: " + data.SelectSingleNode("day/mintemp_c").InnerText + " °C";
                string weatherCode = data.SelectSingleNode("day/condition/code").InnerText;
                dayOnePic.Image = WeatherIconHelper.GetWeatherIcon(Int32.Parse(weatherCode));
                string rainChance = data.SelectSingleNode("day/daily_chance_of_rain").InnerText;
                string snowChance = data.SelectSingleNode("day/daily_chance_of_snow").InnerText;
                dayOneRainChance.Text = (rainChance == "0" ? snowChance : rainChance) + "%";
            }

            if (day == 2)
            {
                DateTime d = DateTime.Parse(data.SelectSingleNode("date").InnerText);
                dayTwoDate.Text = d.ToString("dd.MM.yyyy");
                dayTwoHigh.Text = "H: " + data.SelectSingleNode("day/maxtemp_c").InnerText + " °C";
                dayTwoLow.Text = "L: " + data.SelectSingleNode("day/mintemp_c").InnerText + " °C";
                string weatherCode = data.SelectSingleNode("day/condition/code").InnerText;
                dayTwoPic.Image = WeatherIconHelper.GetWeatherIcon(Int32.Parse(weatherCode));
                string rainChance = data.SelectSingleNode("day/daily_chance_of_rain").InnerText;
                string snowChance = data.SelectSingleNode("day/daily_chance_of_snow").InnerText;
                dayTwoRainChance.Text = (rainChance == "0" ? snowChance : rainChance) + "%";
            }

            if (day == 3)
            {
                DateTime d = DateTime.Parse(data.SelectSingleNode("date").InnerText);
                dayThreeDate.Text = d.ToString("dd.MM.yyyy");
                dayThreeHigh.Text = "H: " + data.SelectSingleNode("day/maxtemp_c").InnerText + " °C";
                dayThreeLow.Text = "L: " + data.SelectSingleNode("day/mintemp_c").InnerText + " °C";
                string weatherCode = data.SelectSingleNode("day/condition/code").InnerText;
                dayThreePic.Image = WeatherIconHelper.GetWeatherIcon(Int32.Parse(weatherCode));
                string rainChance = data.SelectSingleNode("day/daily_chance_of_rain").InnerText;
                string snowChance = data.SelectSingleNode("day/daily_chance_of_snow").InnerText;
                dayThreeRainChance.Text = (rainChance == "0" ? snowChance : rainChance) + "%";
            }
        }

        private void FillHourlyData()
        {
            XmlNodeList hourNodes = _document.SelectNodes("/root/forecast/forecastday/hour");
            int hours = 0;

            foreach (XmlNode hourNode in hourNodes)
            {
                DateTime d = DateTime.Parse(hourNode.SelectSingleNode("time").InnerText);
                DateTime now = DateTime.Now;
                if (now.CompareTo(d) >= 0) 
                {
                    continue;
                }

                if (hours >= maxHourlyHours) 
                {
                    continue;
                }

                AddNodeToHourlyPanel(hourNode, hours);
                hours++;
            }

               
        }

        private void AddNodeToHourlyPanel(XmlNode node, int i)
        {
            DateTime d = DateTime.Parse(node.SelectSingleNode("time").InnerText);
            string rainChance = node.SelectSingleNode("chance_of_rain").InnerText;
            string snowChance = node.SelectSingleNode("chance_of_snow").InnerText;
            string chanceOfRain = (rainChance == "0" ? snowChance : rainChance) + "%";
            string temp = node.SelectSingleNode("temp_c").InnerText + " °C";
            string windSpd = GetXmlValueByPath("/root/current/wind_kph");
            string windDir = GetXmlValueByPath("/root/current/wind_dir");
            string windText = windSpd + " km/h " + windDir;

            panelHourly.Controls.Add(CreatePeriodPanel(
                d.ToString("HH:mm"),
                node.SelectSingleNode("condition/code").InnerText,
                chanceOfRain,
                temp,
                windText,
                new Point(i * hourPanelWidth, 0)
                )
             );
        }
    }
}
