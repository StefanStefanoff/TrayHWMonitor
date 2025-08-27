using HWmonitor.Forms;
using HWmonitor.Widgets;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HWmonitor
{
    public class HWMonitorContext : ApplicationContext
    {
        private readonly ContextMenu ContextMenu;
        private readonly MemoryWidget MemoryWidget = new MemoryWidget();
        private readonly CPUWidget CpuWidget = new CPUWidget(Environment.ProcessorCount);
        private readonly EmptyWidget EmptyWidget  = new EmptyWidget();

        private int widgetsShown = 0;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);

        public HWMonitorContext() 
        {
            ContextMenu = new ContextMenu();
            ContextMenu.MenuItems.Add("Settings", ShowSettings);
            ContextMenu.MenuItems.Add("Exit", Exit);

            if (Properties.Settings.Default.ShowMemory)
            {
                MemoryWidget.InitializeMemoryIcon(ContextMenu);
                MemoryWidget.Start(DestroyIcon);
                widgetsShown++;
            }

            if (Properties.Settings.Default.ShowCPU)
            {
                CpuWidget.InitializeCpuIcons(ContextMenu);
                CpuWidget.Start(DestroyIcon);
                widgetsShown++;
            }

            if (widgetsShown == 0) 
            {
                EmptyWidget.Initialize(ContextMenu);
            }
        }

        void Exit(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ShowCPU)
                CpuWidget.Destroy();

            if (Properties.Settings.Default.ShowMemory)
                MemoryWidget.Destroy();

            if (widgetsShown == 0)
                EmptyWidget.Destroy();

            Environment.Exit(0);
        }
        void ShowSettings(object sender, EventArgs e)
        {
            new Settings().Show();
        }
    }
}
