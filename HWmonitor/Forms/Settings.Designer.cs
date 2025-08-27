namespace HWmonitor.Forms
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CPUCoresPerIcon = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CPURefreshInterval = new System.Windows.Forms.NumericUpDown();
            this.ShowCPUCheckbox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.MemoryRefreshInterval = new System.Windows.Forms.NumericUpDown();
            this.ShowMemoryCheckbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPUCoresPerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPURefreshInterval)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryRefreshInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveBtn.Location = new System.Drawing.Point(249, 263);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(119, 32);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(353, 201);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CPUCoresPerIcon);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CPURefreshInterval);
            this.tabPage1.Controls.Add(this.ShowCPUCheckbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(345, 175);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CPU";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CPUCoresPerIcon
            // 
            this.CPUCoresPerIcon.Location = new System.Drawing.Point(140, 53);
            this.CPUCoresPerIcon.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.CPUCoresPerIcon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CPUCoresPerIcon.Name = "CPUCoresPerIcon";
            this.CPUCoresPerIcon.Size = new System.Drawing.Size(61, 20);
            this.CPUCoresPerIcon.TabIndex = 10;
            this.CPUCoresPerIcon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cores Per Icon (max 8)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Refresh Interval(ms):";
            // 
            // CPURefreshInterval
            // 
            this.CPURefreshInterval.Location = new System.Drawing.Point(140, 27);
            this.CPURefreshInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CPURefreshInterval.Name = "CPURefreshInterval";
            this.CPURefreshInterval.Size = new System.Drawing.Size(61, 20);
            this.CPURefreshInterval.TabIndex = 7;
            // 
            // ShowCPUCheckbox
            // 
            this.ShowCPUCheckbox.AutoSize = true;
            this.ShowCPUCheckbox.Location = new System.Drawing.Point(6, 6);
            this.ShowCPUCheckbox.Name = "ShowCPUCheckbox";
            this.ShowCPUCheckbox.Size = new System.Drawing.Size(106, 17);
            this.ShowCPUCheckbox.TabIndex = 6;
            this.ShowCPUCheckbox.Text = "Show CPU icons";
            this.ShowCPUCheckbox.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.MemoryRefreshInterval);
            this.tabPage2.Controls.Add(this.ShowMemoryCheckbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(345, 175);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Memory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Refresh Interval(ms):";
            // 
            // MemoryRefreshInterval
            // 
            this.MemoryRefreshInterval.Location = new System.Drawing.Point(140, 27);
            this.MemoryRefreshInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MemoryRefreshInterval.Name = "MemoryRefreshInterval";
            this.MemoryRefreshInterval.Size = new System.Drawing.Size(61, 20);
            this.MemoryRefreshInterval.TabIndex = 12;
            // 
            // ShowMemoryCheckbox
            // 
            this.ShowMemoryCheckbox.AutoSize = true;
            this.ShowMemoryCheckbox.Location = new System.Drawing.Point(6, 6);
            this.ShowMemoryCheckbox.Name = "ShowMemoryCheckbox";
            this.ShowMemoryCheckbox.Size = new System.Drawing.Size(116, 17);
            this.ShowMemoryCheckbox.TabIndex = 11;
            this.ShowMemoryCheckbox.Text = "Show Memory icon";
            this.ShowMemoryCheckbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Some setting changes may require a restart";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 307);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.saveBtn);
            this.MaximumSize = new System.Drawing.Size(393, 346);
            this.MinimumSize = new System.Drawing.Size(393, 346);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPUCoresPerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPURefreshInterval)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryRefreshInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown CPUCoresPerIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CPURefreshInterval;
        private System.Windows.Forms.CheckBox ShowCPUCheckbox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown MemoryRefreshInterval;
        private System.Windows.Forms.CheckBox ShowMemoryCheckbox;
        private System.Windows.Forms.Label label3;
    }
}