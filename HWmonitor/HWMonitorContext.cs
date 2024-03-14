using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWmonitor
{
    public class HWMonitorContext : ApplicationContext
    {
        NotifyIcon[] trayIcons;
        Bitmap[] bitmaps;
        NotifyIcon memoryIcon;
        Bitmap memoryBitmap;
        PerformanceCounter[] CPUCounters;
        int cpuCount = 0;
        int interval = 500;
        int coresPerIcon = 8;
        ContextMenu contextMenu;
        Thread notifyThread;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);

        public HWMonitorContext() 
        {
            contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add("Exit", Exit);
            InitializeMemoryIcon();

            cpuCount = (int)Environment.ProcessorCount;
            InitializeCpuIcons(cpuCount);

            notifyThread = new Thread(
            delegate ()
            {
                while (true)
                {
                    RefreshMemoryIcon();
                    RefreshCpuIcons();
                    Task.Delay(interval).Wait();
                }
            });
            notifyThread.Start();
        }

        private void InitializeCpuIcons(int cpuCount)
        {

            CPUCounters = new PerformanceCounter[cpuCount];
            for (var i = 0; i < cpuCount; i++)
            {
                CPUCounters[i] = new PerformanceCounter("Processor", "% Processor Time", $"{i}");
            }

            bitmaps = new Bitmap[cpuCount];
            trayIcons = new NotifyIcon[cpuCount];

            for (int i = 0; i < cpuCount; i+= coresPerIcon)
            {
                this.bitmaps[i] = new Bitmap(16, 16);
            }


            for (int i = 0; i < cpuCount; i+= coresPerIcon)
            {
                trayIcons[i] = new NotifyIcon();
                trayIcons[i].Icon = Icon.FromHandle(bitmaps[i].GetHicon());
                trayIcons[i].ContextMenu = contextMenu;
                trayIcons[i].Visible = true;
            }
        }

        private void InitializeMemoryIcon()
        {
            memoryBitmap = new Bitmap(16, 16);
            memoryIcon = new NotifyIcon();
            memoryIcon.Icon = Icon.FromHandle(memoryBitmap.GetHicon());
            memoryIcon.ContextMenu = contextMenu;
            memoryIcon.Visible = true;
        }

        private void RefreshMemoryIcon()
        {
            memoryBitmap.Dispose();
            memoryBitmap = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(memoryBitmap))
                g.Clear(Color.Transparent);

            ulong total = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
            ulong available = new Microsoft.VisualBasic.Devices.ComputerInfo().AvailablePhysicalMemory;

            double percentAvailable = available * 1.0 / total;

            int availableHeight = (int)Math.Round(percentAvailable * 15);

            Brush color = Brushes.White;

            if (percentAvailable < 0.2) {
                color = Brushes.Orange;
            }
            if (percentAvailable < 0.1)
            {
                color = Brushes.OrangeRed;
            }
            if (percentAvailable < 0.05)
            {
                color = Brushes.Red;
            }

            using (Graphics g = Graphics.FromImage(memoryBitmap))
                g.FillRectangle(color, 1, availableHeight, 14, 15 - availableHeight);

            IntPtr hicon = memoryBitmap.GetHicon();
            memoryIcon.Icon = Icon.FromHandle(hicon);
            DestroyIcon(memoryIcon.Icon.Handle);
        }

        private void RefreshCpuIcons()
        {
            for (int i = 0; i < cpuCount; i+= coresPerIcon)
            {
                int diff = cpuCount - (i+ coresPerIcon);
                int sub = 0;
                if (diff < 0) {
                    sub = diff * -1;
                }

                bitmaps[i].Dispose();
                bitmaps[i] = new Bitmap(16, 16);
                using (Graphics g = Graphics.FromImage(bitmaps[i]))
                    g.Clear(Color.Transparent);

                for (int j = 0; j < coresPerIcon - sub; j++) {
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

        private void SetClick(NotifyIcon icon)
        {
            icon.Click += new System.EventHandler(HWMonitorIcon_Click);
        }

        private void HWMonitorIcon_Click(object sender, System.EventArgs e)
        {
            Console.WriteLine("test");
        }
        void Exit(object sender, EventArgs e)
        {
            notifyThread.Abort();
            for (int i = 0; i < cpuCount; i += coresPerIcon)
            {
                trayIcons[i].Visible = false;
            }
            memoryIcon.Visible = false;
            Environment.Exit(0);
        }
    }
}
