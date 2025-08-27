using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWmonitor.widgets
{
    internal class CPUWidget: BaseWidget
    {
        PerformanceCounter[] CPUCounters;
        NotifyIcon[] trayIcons;
        Bitmap[] bitmaps;
        Thread notifyThread;

        int cpuCount = 0;
        int coresPerIcon = 0;

        public CPUWidget(int cpuCount)
        {
            name = "CPU";
            this.cpuCount = cpuCount;
            coresPerIcon = Int32.Parse(Properties.Settings.Default.CoresPerIcon.ToString());
        }

        public void InitializeCpuIcons(ContextMenu contextMenu)
        {

            CPUCounters = new PerformanceCounter[cpuCount];
            for (var i = 0; i < cpuCount; i++)
            {
                CPUCounters[i] = new PerformanceCounter("Processor", "% Processor Time", $"{i}");
            }

            bitmaps = new Bitmap[cpuCount];
            trayIcons = new NotifyIcon[cpuCount];

            for (int i = 0; i < cpuCount; i += coresPerIcon)
            {
                this.bitmaps[i] = new Bitmap(16, 16);
            }


            for (int i = 0; i < cpuCount; i += coresPerIcon)
            {
                trayIcons[i] = new NotifyIcon();
                trayIcons[i].Icon = Icon.FromHandle(bitmaps[i].GetHicon());
                trayIcons[i].ContextMenu = contextMenu;
                trayIcons[i].Visible = true;
            }
        }

        private void RefreshCpuIcons(Func<IntPtr, bool> DestroyIcon)
        {
            for (int i = 0; i < cpuCount; i += coresPerIcon)
            {
                int diff = cpuCount - (i + coresPerIcon);
                int sub = 0;
                if (diff < 0)
                {
                    sub = diff * -1;
                }

                bitmaps[i].Dispose();
                bitmaps[i] = new Bitmap(16, 16);
                using (Graphics g = Graphics.FromImage(bitmaps[i]))
                    g.Clear(Color.Transparent);

                for (int j = 0; j < coresPerIcon - sub; j++)
                {
                    float coreUsage = GetCpuUsage(i + j);
                    float coreFreePercent = 1 - (coreUsage / 100);
                    int availableCoreHeight = (int)Math.Round(coreFreePercent * 16);

                    using (Graphics g = Graphics.FromImage(bitmaps[i]))
                        g.FillRectangle(Brushes.Gray, 1 + (j * 2), 15, 1, 1);

                    using (Graphics g = Graphics.FromImage(bitmaps[i]))
                        g.FillRectangle(Brushes.White, 1 + (j * 2), availableCoreHeight, 1, 16 - availableCoreHeight);
                }

                IntPtr hicon = bitmaps[i].GetHicon();
                trayIcons[i].Icon = Icon.FromHandle(hicon);
                DestroyIcon(trayIcons[i].Icon.Handle);
            }
        }

        private float GetCpuUsage(int index)
        {
            float value = CPUCounters[index].NextValue();
            CPUCounters[index].NextValue();
            CPUCounters[index].NextValue();

            return value;
        }

        public void Start(Func<IntPtr, bool> DestroyIcon)
        {
            notifyThread = new Thread(
            delegate ()
            {
                while (true)
                {
                    RefreshCpuIcons(DestroyIcon);
                    Task.Delay(GetInterval()).Wait();
                }
            });
            notifyThread.Start();
        }

        public void Destroy()
        {
            notifyThread.Abort();
            for (int i = 0; i < cpuCount; i += coresPerIcon)
            {
                trayIcons[i].Visible = false;
            }
        }
    }
}
