using System;

namespace HWmonitor.Widgets
{
    internal class BaseWidget
    {
        protected string name = "Base";
        protected int defaultInterval = 1000;

        protected int GetInterval()
        {
            try
            {
                int interval = Int32.Parse(Properties.Settings.Default["Interval" + name].ToString());

                if (interval < 100)
                {
                    interval = 100;
                }

                return interval;
            }
            catch
            {
                return defaultInterval;
            }
        }
    }
}
