using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWmonitor.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            CPUCoresPerIcon.Value = Properties.Settings.Default.CoresPerIcon;
            ShowCPUCheckbox.Checked = Properties.Settings.Default.ShowCPU;
            CPURefreshInterval.Value = Properties.Settings.Default.IntervalCPU;

            ShowMemoryCheckbox.Checked = Properties.Settings.Default.ShowMemory;
            MemoryRefreshInterval.Value = Properties.Settings.Default.IntervalMemory;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CoresPerIcon = UInt32.Parse(CPUCoresPerIcon.Value.ToString());
            Properties.Settings.Default.IntervalCPU = UInt32.Parse(CPURefreshInterval.Value.ToString());
            Properties.Settings.Default.IntervalMemory = UInt32.Parse(MemoryRefreshInterval.Value.ToString());

            Properties.Settings.Default.ShowCPU = ShowCPUCheckbox.Checked;
            Properties.Settings.Default.ShowMemory = ShowMemoryCheckbox.Checked;

            Properties.Settings.Default.Save();

            this.Close();
        }
    }
}
