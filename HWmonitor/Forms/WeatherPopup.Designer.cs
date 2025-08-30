namespace HWmonitor.Forms
{
    partial class WeatherPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherPopup));
            this.label1 = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.wind = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.precipitation = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.feelsLike = new System.Windows.Forms.Label();
            this.panelCurrent = new System.Windows.Forms.Panel();
            this.weatherImage = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHourly = new System.Windows.Forms.Panel();
            this.dayOneLow = new System.Windows.Forms.Label();
            this.dayOneDate = new System.Windows.Forms.Label();
            this.dayTwoDate = new System.Windows.Forms.Label();
            this.dayThreeDate = new System.Windows.Forms.Label();
            this.dayOneHigh = new System.Windows.Forms.Label();
            this.dayOneRainChance = new System.Windows.Forms.Label();
            this.dayTwoRainChance = new System.Windows.Forms.Label();
            this.dayTwoHigh = new System.Windows.Forms.Label();
            this.dayTwoLow = new System.Windows.Forms.Label();
            this.dayThreeRainChance = new System.Windows.Forms.Label();
            this.dayThreeHigh = new System.Windows.Forms.Label();
            this.dayThreeLow = new System.Windows.Forms.Label();
            this.dayThreePic = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.dayTwoPic = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.dayOnePic = new System.Windows.Forms.PictureBox();
            this.panelCurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayThreePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayTwoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayOnePic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "City, Country";
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature.ForeColor = System.Drawing.Color.White;
            this.temperature.Location = new System.Drawing.Point(7, 20);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(150, 55);
            this.temperature.TabIndex = 1;
            this.temperature.Text = "20 °C";
            // 
            // wind
            // 
            this.wind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wind.ForeColor = System.Drawing.Color.White;
            this.wind.Location = new System.Drawing.Point(308, 3);
            this.wind.Name = "wind";
            this.wind.Size = new System.Drawing.Size(142, 16);
            this.wind.TabIndex = 3;
            this.wind.Text = "14.4 km/h E";
            this.wind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pressure
            // 
            this.pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressure.ForeColor = System.Drawing.Color.White;
            this.pressure.Location = new System.Drawing.Point(311, 29);
            this.pressure.Name = "pressure";
            this.pressure.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pressure.Size = new System.Drawing.Size(139, 16);
            this.pressure.TabIndex = 4;
            this.pressure.Text = "1019 hPa";
            this.pressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // precipitation
            // 
            this.precipitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitation.ForeColor = System.Drawing.Color.White;
            this.precipitation.Location = new System.Drawing.Point(314, 51);
            this.precipitation.Name = "precipitation";
            this.precipitation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.precipitation.Size = new System.Drawing.Size(136, 16);
            this.precipitation.TabIndex = 5;
            this.precipitation.Text = "0";
            this.precipitation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // humidity
            // 
            this.humidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidity.ForeColor = System.Drawing.Color.White;
            this.humidity.Location = new System.Drawing.Point(311, 77);
            this.humidity.Name = "humidity";
            this.humidity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.humidity.Size = new System.Drawing.Size(139, 16);
            this.humidity.TabIndex = 6;
            this.humidity.Text = "44%";
            this.humidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // feelsLike
            // 
            this.feelsLike.AutoSize = true;
            this.feelsLike.ForeColor = System.Drawing.Color.White;
            this.feelsLike.Location = new System.Drawing.Point(161, 3);
            this.feelsLike.Name = "feelsLike";
            this.feelsLike.Size = new System.Drawing.Size(45, 13);
            this.feelsLike.TabIndex = 7;
            this.feelsLike.Text = "23.6  °C";
            // 
            // panelCurrent
            // 
            this.panelCurrent.Controls.Add(this.weatherImage);
            this.panelCurrent.Controls.Add(this.pictureBox4);
            this.panelCurrent.Controls.Add(this.temperature);
            this.panelCurrent.Controls.Add(this.pictureBox3);
            this.panelCurrent.Controls.Add(this.wind);
            this.panelCurrent.Controls.Add(this.pictureBox2);
            this.panelCurrent.Controls.Add(this.pressure);
            this.panelCurrent.Controls.Add(this.pictureBox1);
            this.panelCurrent.Controls.Add(this.precipitation);
            this.panelCurrent.Controls.Add(this.feelsLike);
            this.panelCurrent.Controls.Add(this.humidity);
            this.panelCurrent.Location = new System.Drawing.Point(0, 48);
            this.panelCurrent.Name = "panelCurrent";
            this.panelCurrent.Size = new System.Drawing.Size(498, 103);
            this.panelCurrent.TabIndex = 12;
            // 
            // weatherImage
            // 
            this.weatherImage.ErrorImage = null;
            this.weatherImage.Image = global::HWmonitor.Properties.Resources.sunny;
            this.weatherImage.InitialImage = null;
            this.weatherImage.Location = new System.Drawing.Point(212, 3);
            this.weatherImage.Name = "weatherImage";
            this.weatherImage.Size = new System.Drawing.Size(90, 90);
            this.weatherImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherImage.TabIndex = 2;
            this.weatherImage.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HWmonitor.Properties.Resources.wind;
            this.pictureBox4.Location = new System.Drawing.Point(456, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HWmonitor.Properties.Resources.pressure;
            this.pictureBox3.Location = new System.Drawing.Point(456, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HWmonitor.Properties.Resources.rain;
            this.pictureBox2.Location = new System.Drawing.Point(456, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HWmonitor.Properties.Resources.precipitation;
            this.pictureBox1.Location = new System.Drawing.Point(456, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panelHourly
            // 
            this.panelHourly.AutoScroll = true;
            this.panelHourly.Location = new System.Drawing.Point(0, 178);
            this.panelHourly.Name = "panelHourly";
            this.panelHourly.Size = new System.Drawing.Size(498, 162);
            this.panelHourly.TabIndex = 13;
            // 
            // dayOneLow
            // 
            this.dayOneLow.ForeColor = System.Drawing.Color.White;
            this.dayOneLow.Location = new System.Drawing.Point(90, 393);
            this.dayOneLow.Name = "dayOneLow";
            this.dayOneLow.Size = new System.Drawing.Size(69, 13);
            this.dayOneLow.TabIndex = 15;
            this.dayOneLow.Text = "L: 15 °C";
            this.dayOneLow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dayOneDate
            // 
            this.dayOneDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOneDate.ForeColor = System.Drawing.Color.White;
            this.dayOneDate.Location = new System.Drawing.Point(24, 355);
            this.dayOneDate.Name = "dayOneDate";
            this.dayOneDate.Size = new System.Drawing.Size(123, 23);
            this.dayOneDate.TabIndex = 19;
            this.dayOneDate.Text = "29.08.2025";
            this.dayOneDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayTwoDate
            // 
            this.dayTwoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayTwoDate.ForeColor = System.Drawing.Color.White;
            this.dayTwoDate.Location = new System.Drawing.Point(179, 355);
            this.dayTwoDate.Name = "dayTwoDate";
            this.dayTwoDate.Size = new System.Drawing.Size(123, 23);
            this.dayTwoDate.TabIndex = 30;
            this.dayTwoDate.Text = "29.08.2025";
            this.dayTwoDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayThreeDate
            // 
            this.dayThreeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayThreeDate.ForeColor = System.Drawing.Color.White;
            this.dayThreeDate.Location = new System.Drawing.Point(334, 355);
            this.dayThreeDate.Name = "dayThreeDate";
            this.dayThreeDate.Size = new System.Drawing.Size(123, 23);
            this.dayThreeDate.TabIndex = 31;
            this.dayThreeDate.Text = "29.08.2025";
            this.dayThreeDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayOneHigh
            // 
            this.dayOneHigh.ForeColor = System.Drawing.Color.White;
            this.dayOneHigh.Location = new System.Drawing.Point(90, 411);
            this.dayOneHigh.Name = "dayOneHigh";
            this.dayOneHigh.Size = new System.Drawing.Size(69, 13);
            this.dayOneHigh.TabIndex = 32;
            this.dayOneHigh.Text = "H: 25 °C";
            this.dayOneHigh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dayOneRainChance
            // 
            this.dayOneRainChance.ForeColor = System.Drawing.Color.White;
            this.dayOneRainChance.Location = new System.Drawing.Point(90, 429);
            this.dayOneRainChance.Name = "dayOneRainChance";
            this.dayOneRainChance.Size = new System.Drawing.Size(69, 13);
            this.dayOneRainChance.TabIndex = 33;
            this.dayOneRainChance.Text = "44%";
            this.dayOneRainChance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dayTwoRainChance
            // 
            this.dayTwoRainChance.ForeColor = System.Drawing.Color.White;
            this.dayTwoRainChance.Location = new System.Drawing.Point(246, 429);
            this.dayTwoRainChance.Name = "dayTwoRainChance";
            this.dayTwoRainChance.Size = new System.Drawing.Size(69, 13);
            this.dayTwoRainChance.TabIndex = 36;
            this.dayTwoRainChance.Text = "44%";
            this.dayTwoRainChance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dayTwoHigh
            // 
            this.dayTwoHigh.ForeColor = System.Drawing.Color.White;
            this.dayTwoHigh.Location = new System.Drawing.Point(246, 411);
            this.dayTwoHigh.Name = "dayTwoHigh";
            this.dayTwoHigh.Size = new System.Drawing.Size(69, 13);
            this.dayTwoHigh.TabIndex = 35;
            this.dayTwoHigh.Text = "H: 25 °C";
            this.dayTwoHigh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dayTwoLow
            // 
            this.dayTwoLow.ForeColor = System.Drawing.Color.White;
            this.dayTwoLow.Location = new System.Drawing.Point(246, 393);
            this.dayTwoLow.Name = "dayTwoLow";
            this.dayTwoLow.Size = new System.Drawing.Size(69, 13);
            this.dayTwoLow.TabIndex = 34;
            this.dayTwoLow.Text = "L: 15 °C";
            this.dayTwoLow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dayThreeRainChance
            // 
            this.dayThreeRainChance.ForeColor = System.Drawing.Color.White;
            this.dayThreeRainChance.Location = new System.Drawing.Point(398, 429);
            this.dayThreeRainChance.Name = "dayThreeRainChance";
            this.dayThreeRainChance.Size = new System.Drawing.Size(69, 13);
            this.dayThreeRainChance.TabIndex = 39;
            this.dayThreeRainChance.Text = "44%";
            this.dayThreeRainChance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dayThreeHigh
            // 
            this.dayThreeHigh.ForeColor = System.Drawing.Color.White;
            this.dayThreeHigh.Location = new System.Drawing.Point(398, 411);
            this.dayThreeHigh.Name = "dayThreeHigh";
            this.dayThreeHigh.Size = new System.Drawing.Size(69, 13);
            this.dayThreeHigh.TabIndex = 38;
            this.dayThreeHigh.Text = "H: 25 °C";
            this.dayThreeHigh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dayThreeLow
            // 
            this.dayThreeLow.ForeColor = System.Drawing.Color.White;
            this.dayThreeLow.Location = new System.Drawing.Point(398, 393);
            this.dayThreeLow.Name = "dayThreeLow";
            this.dayThreeLow.Size = new System.Drawing.Size(69, 13);
            this.dayThreeLow.TabIndex = 37;
            this.dayThreeLow.Text = "L: 15 °C";
            this.dayThreeLow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dayThreePic
            // 
            this.dayThreePic.Image = global::HWmonitor.Properties.Resources.heavy_rain;
            this.dayThreePic.Location = new System.Drawing.Point(337, 390);
            this.dayThreePic.Name = "dayThreePic";
            this.dayThreePic.Size = new System.Drawing.Size(64, 56);
            this.dayThreePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dayThreePic.TabIndex = 26;
            this.dayThreePic.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(320, 390);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1, 56);
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            // 
            // dayTwoPic
            // 
            this.dayTwoPic.Image = global::HWmonitor.Properties.Resources.thunder_rain;
            this.dayTwoPic.Location = new System.Drawing.Point(182, 390);
            this.dayTwoPic.Name = "dayTwoPic";
            this.dayTwoPic.Size = new System.Drawing.Size(64, 56);
            this.dayTwoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dayTwoPic.TabIndex = 20;
            this.dayTwoPic.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(165, 390);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1, 56);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // dayOnePic
            // 
            this.dayOnePic.Image = global::HWmonitor.Properties.Resources.drizzle;
            this.dayOnePic.Location = new System.Drawing.Point(27, 390);
            this.dayOnePic.Name = "dayOnePic";
            this.dayOnePic.Size = new System.Drawing.Size(64, 56);
            this.dayOnePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dayOnePic.TabIndex = 14;
            this.dayOnePic.TabStop = false;
            // 
            // WeatherPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(498, 466);
            this.ControlBox = false;
            this.Controls.Add(this.dayThreeRainChance);
            this.Controls.Add(this.dayThreeHigh);
            this.Controls.Add(this.dayThreeLow);
            this.Controls.Add(this.dayTwoRainChance);
            this.Controls.Add(this.dayTwoHigh);
            this.Controls.Add(this.dayTwoLow);
            this.Controls.Add(this.dayOneRainChance);
            this.Controls.Add(this.dayOneHigh);
            this.Controls.Add(this.dayThreeDate);
            this.Controls.Add(this.dayTwoDate);
            this.Controls.Add(this.dayThreePic);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.dayTwoPic);
            this.Controls.Add(this.dayOneDate);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.dayOneLow);
            this.Controls.Add(this.dayOnePic);
            this.Controls.Add(this.panelHourly);
            this.Controls.Add(this.panelCurrent);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(498, 466);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(498, 466);
            this.Name = "WeatherPopup";
            this.Opacity = 0.95D;
            this.panelCurrent.ResumeLayout(false);
            this.panelCurrent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayThreePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayTwoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayOnePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.PictureBox weatherImage;
        private System.Windows.Forms.Label wind;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label precipitation;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label feelsLike;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelCurrent;
        private System.Windows.Forms.Panel panelHourly;
        private System.Windows.Forms.PictureBox dayOnePic;
        private System.Windows.Forms.Label dayOneLow;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label dayOneDate;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox dayTwoPic;
        private System.Windows.Forms.PictureBox dayThreePic;
        private System.Windows.Forms.Label dayTwoDate;
        private System.Windows.Forms.Label dayThreeDate;
        private System.Windows.Forms.Label dayOneHigh;
        private System.Windows.Forms.Label dayOneRainChance;
        private System.Windows.Forms.Label dayTwoRainChance;
        private System.Windows.Forms.Label dayTwoHigh;
        private System.Windows.Forms.Label dayTwoLow;
        private System.Windows.Forms.Label dayThreeRainChance;
        private System.Windows.Forms.Label dayThreeHigh;
        private System.Windows.Forms.Label dayThreeLow;
    }
}