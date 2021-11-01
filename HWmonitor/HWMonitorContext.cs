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

            for (int i = 0; i < cpuCount; i+=2)
            {
                this.bitmaps[i] = new Bitmap(16, 16);
            }


            for (int i = 0; i < cpuCount; i+=2)
            {
                trayIcons[i] = new NotifyIcon();
                using (Graphics g = Graphics.FromImage(bitmaps[i]))
                    g.DrawRectangle(Pens.White, 1, 0, 6, 15);
                using (Graphics g = Graphics.FromImage(bitmaps[i]))
                    g.DrawRectangle(Pens.White, 9, 0, 6, 15);
                trayIcons[i].Icon = Icon.FromHandle(bitmaps[i].GetHicon());
                trayIcons[i].ContextMenu = contextMenu;
                trayIcons[i].Visible = true;
            }
        }

        private void InitializeMemoryIcon()
        {
            memoryBitmap = new Bitmap(16, 16);
            memoryIcon = new NotifyIcon();
            using (Graphics g = Graphics.FromImage(memoryBitmap))
                g.DrawRectangle(Pens.White, 0, 0, 15, 15);
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
            using (Graphics g = Graphics.FromImage(memoryBitmap))
                g.DrawRectangle(Pens.White, 0, 0, 15, 15);


            ulong total = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
            ulong available = new Microsoft.VisualBasic.Devices.ComputerInfo().AvailablePhysicalMemory;

            double percentAvailable = available * 1.0 / total;

            int availableHeight = (int)Math.Round(percentAvailable * 15);

            using (Graphics g = Graphics.FromImage(memoryBitmap))
                g.FillRectangle(Brushes.White, 0, availableHeight, 15, 15 - availableHeight);

            IntPtr hicon = memoryBitmap.GetHicon();
            memoryIcon.Icon = Icon.FromHandle(hicon);
            DestroyIcon(memoryIcon.Icon.Handle);
        }

        private void RefreshCpuIcons()
        {
            for (int i = 0; i < cpuCount; i+=2)
            {
                float core1Usage = GetCpuUsage(i);
                float core2Usage = GetCpuUsage(i + 1);


                float core1FreePercent = 1 - (core1Usage / 100);
                float core2FreePercent = 1 - (core2Usage / 100);

                int availableC1Height = (int)Math.Round(core1FreePercent * 15);
                int availableC2Height = (int)Math.Round(core2FreePercent * 15);


                bitmaps[i].Dispose();
                bitmaps[i] = new Bitmap(16, 16);
                using (Graphics g = Graphics.FromImage(bitmaps[i]))
                    g.Clear(Color.Transparent);


                using (Graphics g = Graphics.FromImage(bitmaps[i]))
                    g.DrawRectangle(Pens.White, 1, 0, 6, 15);
                using (Graphics g = Graphics.FromImage(bitmaps[i]))
                    g.DrawRectangle(Pens.White, 9, 0, 6, 15);

                using (Graphics g = Graphics.FromImage(bitmaps[i]))
                    g.FillRectangle(Brushes.White, 1, availableC1Height, 6, 15 - availableC1Height);
                using (Graphics g = Graphics.FromImage(bitmaps[i]))
                    g.FillRectangle(Brushes.White, 9, availableC2Height, 6, 15 - availableC2Height);


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
            for (int i = 0; i < cpuCount; i += 2)
            {
                trayIcons[i].Visible = false;
            }
            memoryIcon.Visible = false;
            Environment.Exit(0);
        }
    }
}
