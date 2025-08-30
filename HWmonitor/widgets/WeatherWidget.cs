using HWmonitor.Forms;
using HWmonitor.Helpers;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HWmonitor.Widgets
{
    internal class WeatherWidget: BaseWidget
    {
        Bitmap weatherBitmap;
        NotifyIcon weatherIcon;
        Thread notifyThread;
        private readonly HttpClient client;
        XmlDocument weatherXml = new XmlDocument();
        WeatherPopup popup = new WeatherPopup();

        public WeatherWidget()
        {
            name = "Weather";
            HttpClientHandler handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            client = new HttpClient(handler);
        }

        public void InitializeWeatherIcon(ContextMenu contextMenu)
        {
            weatherBitmap = new Bitmap(16, 16);
            weatherIcon = new NotifyIcon();
            weatherIcon.Icon = Icon.FromHandle(weatherBitmap.GetHicon());
            weatherIcon.ContextMenu = contextMenu;
            weatherIcon.Visible = true;

            weatherIcon.Click += new System.EventHandler(DisplayWeatherPopup);
        }

        private void DisplayWeatherPopup(object sender, System.EventArgs e) 
        {
            if (popup.Visible)
            {
                popup.Hide();
            }
            else
            {
                int x = Screen.PrimaryScreen.WorkingArea.Width - (popup.Width + 10);
                int y = Screen.PrimaryScreen.WorkingArea.Height - (popup.Height + 10);
                popup.StartPosition = FormStartPosition.Manual;
                popup.Location = new Point(x, y);
                popup.SetWeatherData(weatherXml);
                popup.ShowDialog();
            }
        }

        private void RefreshWeatherIcon(Func<IntPtr, bool> DestroyIcon)
        {
            weatherBitmap.Dispose();
            weatherBitmap = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(weatherBitmap))
                g.Clear(Color.Transparent);

            
            getWeatherResponse();
            int weatherCode = getWeatherConditionCode(weatherXml);


            using (Graphics g = Graphics.FromImage(weatherBitmap))
            {
                g.DrawImage(WeatherIconHelper.GetWeatherIcon(weatherCode), 0, 0, 16, 16);
            }

            IntPtr hicon = weatherBitmap.GetHicon();
            weatherIcon.Icon = Icon.FromHandle(hicon);
            DestroyIcon(weatherIcon.Icon.Handle);
        }

        private int getWeatherConditionCode(XmlDocument xmlDocument) 
        {
            XmlNodeList xnList = xmlDocument.SelectNodes("/root/current/condition/code");
            string code = "";

            foreach (XmlNode xn in xnList) 
            {
                code = xn.InnerText;
            }

            int result;
            if (Int32.TryParse(code, out result)) 
            {
                return result;
            }

            return 1000;
            
        }

        private void getWeatherResponse()
        {
            HttpResponseMessage httpResponse = client.GetAsync("http://api.weatherapi.com/v1/forecast.xml?q=Bulgaria Plovdiv 4002&key={key}&days=3").Result;

            string body = httpResponse.Content.ReadAsStringAsync().Result;

            try
            {
                weatherXml.LoadXml(body);
            }
            catch {
                //do nothing
            }
        }

        public void Start(Func<IntPtr, bool> DestroyIcon)
        {
           notifyThread = new Thread(
           delegate ()
           {
               while (true)
               {
                   RefreshWeatherIcon(DestroyIcon);
                   Task.Delay(GetInterval()).Wait();
               }
           });
           notifyThread.Start();
        }

        public void Destroy()
        {
            notifyThread.Abort();
            weatherIcon.Visible = false;
        }
    }
}
