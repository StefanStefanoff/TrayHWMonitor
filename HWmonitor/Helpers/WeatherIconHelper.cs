using System.Collections.Generic;
using System.Drawing;

namespace HWmonitor.Helpers
{
    internal class WeatherIconHelper
    {
        private static readonly Dictionary<int, Bitmap> weatherIconMap = new Dictionary<int, Bitmap>
        {
            { 1000, Properties.Resources.sunny },
            { 1003, Properties.Resources.partly_cloudy },
            { 1006, Properties.Resources.cloudy },
            { 1009, Properties.Resources.cloudy },
            { 1030, Properties.Resources.fog },
            { 1063, Properties.Resources.drizzle },
            { 1066, Properties.Resources.snow },
            { 1069, Properties.Resources.sleet },
            { 1072, Properties.Resources.drizzle },
            { 1087, Properties.Resources.thunder },
            { 1114, Properties.Resources.snow },
            { 1117, Properties.Resources.blizzard },
            { 1135, Properties.Resources.fog },
            { 1147, Properties.Resources.fog },
            { 1150, Properties.Resources.drizzle },
            { 1153, Properties.Resources.drizzle },
            { 1168, Properties.Resources.drizzle },
            { 1171, Properties.Resources.drizzle },
            { 1180, Properties.Resources.drizzle },
            { 1183, Properties.Resources.drizzle },
            { 1186, Properties.Resources.rain },
            { 1189, Properties.Resources.rain },
            { 1192, Properties.Resources.heavy_rain },
            { 1195, Properties.Resources.heavy_rain },
            { 1198, Properties.Resources.drizzle },
            { 1201, Properties.Resources.heavy_rain },
            { 1204, Properties.Resources.sleet },
            { 1207, Properties.Resources.sleet },
            { 1210, Properties.Resources.snow },
            { 1213, Properties.Resources.snow },
            { 1216, Properties.Resources.snow },
            { 1219, Properties.Resources.snow },
            { 1222, Properties.Resources.snow },
            { 1225, Properties.Resources.snow },
            { 1237, Properties.Resources.snow },
            { 1240, Properties.Resources.drizzle },
            { 1243, Properties.Resources.heavy_rain },
            { 1246, Properties.Resources.heavy_rain },
            { 1249, Properties.Resources.sleet },
            { 1252, Properties.Resources.sleet },
            { 1255, Properties.Resources.snow },
            { 1258, Properties.Resources.snow },
            { 1261, Properties.Resources.snow },
            { 1264, Properties.Resources.snow },
            { 1273, Properties.Resources.thunder_rain },
            { 1276, Properties.Resources.thunder_rain },
            { 1279, Properties.Resources.snow },
            { 1282, Properties.Resources.blizzard },

        };

        public static Bitmap GetWeatherIcon(int code)
        {
            if (weatherIconMap.ContainsKey(code)) 
            { 
                return weatherIconMap[code];
            }

            return Properties.Resources.sunny;
        }
    }
}
