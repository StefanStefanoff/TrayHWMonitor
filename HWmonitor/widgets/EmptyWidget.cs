using System.Drawing;
using System.Windows.Forms;

namespace HWmonitor.Widgets
{
    internal class EmptyWidget
    {
        Bitmap memoryBitmap;
        NotifyIcon memoryIcon;

        public void Initialize(ContextMenu contextMenu)
        {
            memoryBitmap = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(memoryBitmap))
                g.Clear(Color.Red);
            memoryIcon = new NotifyIcon();
            memoryIcon.Icon = Icon.FromHandle(memoryBitmap.GetHicon());
            memoryIcon.ContextMenu = contextMenu;
            memoryIcon.Visible = true;
        }

        public void Destroy()
        {
            memoryIcon.Visible = false;
        }
    }
}
