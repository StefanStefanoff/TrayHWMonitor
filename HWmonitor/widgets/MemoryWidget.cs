using HWmonitor.widgets;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWmonitor
{
    internal class MemoryWidget: BaseWidget
    {
        Bitmap memoryBitmap;
        NotifyIcon memoryIcon;
        Thread notifyThread;

        public MemoryWidget()
        {
            name = "Memory";
        }

        public void InitializeMemoryIcon(ContextMenu contextMenu)
        {
            memoryBitmap = new Bitmap(16, 16);
            memoryIcon = new NotifyIcon();
            memoryIcon.Icon = Icon.FromHandle(memoryBitmap.GetHicon());
            memoryIcon.ContextMenu = contextMenu;
            memoryIcon.Visible = true;
        }

        private void RefreshMemoryIcon(Func<IntPtr, bool> DestroyIcon)
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

            if (percentAvailable < 0.2)
            {
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

        public void Start(Func<IntPtr, bool> DestroyIcon)
        {
           notifyThread = new Thread(
           delegate ()
           {
               while (true)
               {
                   RefreshMemoryIcon(DestroyIcon);
                   Task.Delay(GetInterval()).Wait();
               }
           });
           notifyThread.Start();
        }

        public void Destroy()
        {
            notifyThread.Abort();
            memoryIcon.Visible = false;
        }
    }
}
