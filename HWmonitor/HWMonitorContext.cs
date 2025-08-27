using HWmonitor.widgets;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace HWmonitor
{
    public class HWMonitorContext : ApplicationContext
    {
        ContextMenu contextMenu;

        MemoryWidget memoryWidget = new MemoryWidget();
        CPUWidget cpuWidget = new CPUWidget((int)Environment.ProcessorCount);

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);

        public HWMonitorContext() 
        {
            contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add("Settings", ShowSettings);
            contextMenu.MenuItems.Add("Exit", Exit);

            memoryWidget.InitializeMemoryIcon(contextMenu);
            memoryWidget.Start(DestroyIcon);
            cpuWidget.InitializeCpuIcons(contextMenu);
            cpuWidget.Start(DestroyIcon);
        }

        void Exit(object sender, EventArgs e)
        {
            cpuWidget.Destroy();
            memoryWidget.Destroy();
            Environment.Exit(0);
        }
        void ShowSettings(object sender, EventArgs e)
        {
            //TODO: Show Settings Panel
        }
    }
}
