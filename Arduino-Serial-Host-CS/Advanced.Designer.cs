namespace Arduino_Serial_Host_CS
{
    partial class Advanced
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
            this.components = new System.ComponentModel.Container();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_random = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_rgb_gradient = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.timer_RGB_Gradient = new System.Windows.Forms.Timer(this.components);
            this.btn_DESK = new System.Windows.Forms.Button();
            this.btn_PC = new System.Windows.Forms.Button();
            this.Arduino_Port = new System.IO.Ports.SerialPort(this.components);
            this.timer_display = new System.Windows.Forms.Timer(this.components);
            this.picBox_1_2 = new System.Windows.Forms.PictureBox();
            this.btn_AverageDisplayColor = new System.Windows.Forms.Button();
            this.picBox_1_1 = new System.Windows.Forms.PictureBox();
            this.lbl_hue = new System.Windows.Forms.Label();
            this.lbl_saturation = new System.Windows.Forms.Label();
            this.lbl_brightness = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar_saturation = new System.Windows.Forms.TrackBar();
            this.button_enables_overide = new System.Windows.Forms.Button();
            this.trackBar_brightness = new System.Windows.Forms.TrackBar();
            this.btn_AverageDisplayColor_V2 = new System.Windows.Forms.Button();
            this.timer_display_V2 = new System.Windows.Forms.Timer(this.components);
            this.picBox_2_2 = new System.Windows.Forms.PictureBox();
            this.picBox_2_1 = new System.Windows.Forms.PictureBox();
            this.lbl_delay = new System.Windows.Forms.Label();
            this.btn_delay_up = new System.Windows.Forms.Button();
            this.timer_display_V3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_2_1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.BackgroundImage = global::Arduino_Serial_Host_CS.Properties.Resources.Power_Off;
            this.btn_connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_connect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_connect.Location = new System.Drawing.Point(12, 12);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(54, 54);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_click);
            // 
            // btn_random
            // 
            this.btn_random.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(91)))));
            this.btn_random.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_random.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_random.ForeColor = System.Drawing.Color.Gray;
            this.btn_random.Location = new System.Drawing.Point(12, 120);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(212, 89);
            this.btn_random.TabIndex = 2;
            this.btn_random.Text = "Zufällig";
            this.btn_random.UseVisualStyleBackColor = false;
            this.btn_random.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_rgb_gradient
            // 
            this.btn_rgb_gradient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(91)))));
            this.btn_rgb_gradient.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_rgb_gradient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rgb_gradient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rgb_gradient.ForeColor = System.Drawing.Color.Gray;
            this.btn_rgb_gradient.Location = new System.Drawing.Point(12, 215);
            this.btn_rgb_gradient.Name = "btn_rgb_gradient";
            this.btn_rgb_gradient.Size = new System.Drawing.Size(212, 89);
            this.btn_rgb_gradient.TabIndex = 3;
            this.btn_rgb_gradient.Text = "Farbverlauf";
            this.btn_rgb_gradient.UseVisualStyleBackColor = false;
            this.btn_rgb_gradient.Click += new System.EventHandler(this.btn_rgb_gradient_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(98, 71);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(145, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // timer_RGB_Gradient
            // 
            this.timer_RGB_Gradient.Interval = 1000;
            this.timer_RGB_Gradient.Tick += new System.EventHandler(this.timer_RGB_Gradient_Tick);
            // 
            // btn_DESK
            // 
            this.btn_DESK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(91)))));
            this.btn_DESK.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_DESK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DESK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_DESK.ForeColor = System.Drawing.Color.Gray;
            this.btn_DESK.Location = new System.Drawing.Point(276, 120);
            this.btn_DESK.Name = "btn_DESK";
            this.btn_DESK.Size = new System.Drawing.Size(145, 43);
            this.btn_DESK.TabIndex = 6;
            this.btn_DESK.Text = "Desk";
            this.btn_DESK.UseVisualStyleBackColor = false;
            this.btn_DESK.Click += new System.EventHandler(this.btn_DESK_Click);
            // 
            // btn_PC
            // 
            this.btn_PC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(91)))));
            this.btn_PC.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_PC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_PC.ForeColor = System.Drawing.Color.Gray;
            this.btn_PC.Location = new System.Drawing.Point(276, 166);
            this.btn_PC.Name = "btn_PC";
            this.btn_PC.Size = new System.Drawing.Size(145, 43);
            this.btn_PC.TabIndex = 7;
            this.btn_PC.Text = "PC";
            this.btn_PC.UseVisualStyleBackColor = false;
            this.btn_PC.Click += new System.EventHandler(this.btn_PC_Click);
            // 
            // Arduino_Port
            // 
            this.Arduino_Port.PortName = "COM3";
            // 
            // timer_display
            // 
            this.timer_display.Interval = 1500;
            this.timer_display.Tick += new System.EventHandler(this.timer_display_Tick);
            // 
            // picBox_1_2
            // 
            this.picBox_1_2.Location = new System.Drawing.Point(750, 12);
            this.picBox_1_2.Name = "picBox_1_2";
            this.picBox_1_2.Size = new System.Drawing.Size(171, 54);
            this.picBox_1_2.TabIndex = 8;
            this.picBox_1_2.TabStop = false;
            // 
            // btn_AverageDisplayColor
            // 
            this.btn_AverageDisplayColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(91)))));
            this.btn_AverageDisplayColor.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_AverageDisplayColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AverageDisplayColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AverageDisplayColor.ForeColor = System.Drawing.Color.Gray;
            this.btn_AverageDisplayColor.Location = new System.Drawing.Point(12, 310);
            this.btn_AverageDisplayColor.Name = "btn_AverageDisplayColor";
            this.btn_AverageDisplayColor.Size = new System.Drawing.Size(212, 89);
            this.btn_AverageDisplayColor.TabIndex = 9;
            this.btn_AverageDisplayColor.Text = "Durchschnittliche Bildschirmfarbe V1";
            this.btn_AverageDisplayColor.UseVisualStyleBackColor = false;
            this.btn_AverageDisplayColor.Click += new System.EventHandler(this.btn_AverageDisplayColor_Click);
            // 
            // picBox_1_1
            // 
            this.picBox_1_1.Location = new System.Drawing.Point(573, 12);
            this.picBox_1_1.Name = "picBox_1_1";
            this.picBox_1_1.Size = new System.Drawing.Size(171, 54);
            this.picBox_1_1.TabIndex = 10;
            this.picBox_1_1.TabStop = false;
            // 
            // lbl_hue
            // 
            this.lbl_hue.AutoSize = true;
            this.lbl_hue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hue.Location = new System.Drawing.Point(862, 128);
            this.lbl_hue.Name = "lbl_hue";
            this.lbl_hue.Size = new System.Drawing.Size(20, 24);
            this.lbl_hue.TabIndex = 13;
            this.lbl_hue.Text = "0";
            // 
            // lbl_saturation
            // 
            this.lbl_saturation.AutoSize = true;
            this.lbl_saturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saturation.Location = new System.Drawing.Point(862, 152);
            this.lbl_saturation.Name = "lbl_saturation";
            this.lbl_saturation.Size = new System.Drawing.Size(20, 24);
            this.lbl_saturation.TabIndex = 14;
            this.lbl_saturation.Text = "1";
            // 
            // lbl_brightness
            // 
            this.lbl_brightness.AutoSize = true;
            this.lbl_brightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brightness.Location = new System.Drawing.Point(862, 176);
            this.lbl_brightness.Name = "lbl_brightness";
            this.lbl_brightness.Size = new System.Drawing.Size(35, 24);
            this.lbl_brightness.TabIndex = 15;
            this.lbl_brightness.Text = "0.5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(746, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Brightness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(746, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Saturation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(746, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hue";
            // 
            // trackBar_saturation
            // 
            this.trackBar_saturation.Location = new System.Drawing.Point(625, 506);
            this.trackBar_saturation.Maximum = 1000;
            this.trackBar_saturation.Name = "trackBar_saturation";
            this.trackBar_saturation.Size = new System.Drawing.Size(338, 45);
            this.trackBar_saturation.TabIndex = 19;
            // 
            // button_enables_overide
            // 
            this.button_enables_overide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(91)))));
            this.button_enables_overide.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_enables_overide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enables_overide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_enables_overide.ForeColor = System.Drawing.Color.Gray;
            this.button_enables_overide.Location = new System.Drawing.Point(474, 557);
            this.button_enables_overide.Name = "button_enables_overide";
            this.button_enables_overide.Size = new System.Drawing.Size(145, 43);
            this.button_enables_overide.TabIndex = 20;
            this.button_enables_overide.Text = "Overide";
            this.button_enables_overide.UseVisualStyleBackColor = false;
            this.button_enables_overide.Click += new System.EventHandler(this.button_enables_overide_Click);
            // 
            // trackBar_brightness
            // 
            this.trackBar_brightness.Location = new System.Drawing.Point(625, 557);
            this.trackBar_brightness.Maximum = 1000;
            this.trackBar_brightness.Name = "trackBar_brightness";
            this.trackBar_brightness.Size = new System.Drawing.Size(338, 45);
            this.trackBar_brightness.TabIndex = 21;
            // 
            // btn_AverageDisplayColor_V2
            // 
            this.btn_AverageDisplayColor_V2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(91)))));
            this.btn_AverageDisplayColor_V2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_AverageDisplayColor_V2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AverageDisplayColor_V2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AverageDisplayColor_V2.ForeColor = System.Drawing.Color.Gray;
            this.btn_AverageDisplayColor_V2.Location = new System.Drawing.Point(12, 405);
            this.btn_AverageDisplayColor_V2.Name = "btn_AverageDisplayColor_V2";
            this.btn_AverageDisplayColor_V2.Size = new System.Drawing.Size(212, 89);
            this.btn_AverageDisplayColor_V2.TabIndex = 25;
            this.btn_AverageDisplayColor_V2.Text = "Durchschnittliche Bildschirmfarbe V2";
            this.btn_AverageDisplayColor_V2.UseVisualStyleBackColor = false;
            this.btn_AverageDisplayColor_V2.Click += new System.EventHandler(this.btn_AverageDisplayColor_V2_Click);
            // 
            // timer_display_V2
            // 
            this.timer_display_V2.Interval = 10000;
            this.timer_display_V2.Tick += new System.EventHandler(this.timer_display_V2_Tick);
            // 
            // picBox_2_2
            // 
            this.picBox_2_2.Location = new System.Drawing.Point(750, 71);
            this.picBox_2_2.Name = "picBox_2_2";
            this.picBox_2_2.Size = new System.Drawing.Size(171, 54);
            this.picBox_2_2.TabIndex = 27;
            this.picBox_2_2.TabStop = false;
            // 
            // picBox_2_1
            // 
            this.picBox_2_1.Location = new System.Drawing.Point(573, 72);
            this.picBox_2_1.Name = "picBox_2_1";
            this.picBox_2_1.Size = new System.Drawing.Size(171, 54);
            this.picBox_2_1.TabIndex = 28;
            this.picBox_2_1.TabStop = false;
            // 
            // lbl_delay
            // 
            this.lbl_delay.AutoSize = true;
            this.lbl_delay.Location = new System.Drawing.Point(273, 71);
            this.lbl_delay.Name = "lbl_delay";
            this.lbl_delay.Size = new System.Drawing.Size(31, 13);
            this.lbl_delay.TabIndex = 29;
            this.lbl_delay.Text = "1000";
            // 
            // btn_delay_up
            // 
            this.btn_delay_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delay_up.Location = new System.Drawing.Point(342, 63);
            this.btn_delay_up.Name = "btn_delay_up";
            this.btn_delay_up.Size = new System.Drawing.Size(59, 21);
            this.btn_delay_up.TabIndex = 30;
            this.btn_delay_up.Text = "button1";
            this.btn_delay_up.UseVisualStyleBackColor = true;
            // 
            // timer_display_V3
            // 
            this.timer_display_V3.Interval = 10000;
            this.timer_display_V3.Tick += new System.EventHandler(this.timer_display_V3_Tick);
            // 
            // Advanced
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(975, 614);
            this.Controls.Add(this.btn_delay_up);
            this.Controls.Add(this.lbl_delay);
            this.Controls.Add(this.picBox_2_1);
            this.Controls.Add(this.picBox_2_2);
            this.Controls.Add(this.btn_AverageDisplayColor_V2);
            this.Controls.Add(this.trackBar_brightness);
            this.Controls.Add(this.button_enables_overide);
            this.Controls.Add(this.trackBar_saturation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_brightness);
            this.Controls.Add(this.lbl_saturation);
            this.Controls.Add(this.lbl_hue);
            this.Controls.Add(this.picBox_1_1);
            this.Controls.Add(this.btn_AverageDisplayColor);
            this.Controls.Add(this.picBox_1_2);
            this.Controls.Add(this.btn_PC);
            this.Controls.Add(this.btn_DESK);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_rgb_gradient);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.btn_connect);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Advanced";
            this.Text = "Basics";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_2_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_rgb_gradient;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer_RGB_Gradient;
        private System.Windows.Forms.Button btn_DESK;
        private System.Windows.Forms.Button btn_PC;
        private System.IO.Ports.SerialPort Arduino_Port;
        private System.Windows.Forms.Timer timer_display;
        private System.Windows.Forms.PictureBox picBox_1_2;
        private System.Windows.Forms.Button btn_AverageDisplayColor;
        private System.Windows.Forms.PictureBox picBox_1_1;
        private System.Windows.Forms.Label lbl_hue;
        private System.Windows.Forms.Label lbl_saturation;
        private System.Windows.Forms.Label lbl_brightness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar_saturation;
        private System.Windows.Forms.Button button_enables_overide;
        private System.Windows.Forms.TrackBar trackBar_brightness;
        private System.Windows.Forms.Button btn_AverageDisplayColor_V2;
        private System.Windows.Forms.Timer timer_display_V2;
        private System.Windows.Forms.PictureBox picBox_2_2;
        private System.Windows.Forms.PictureBox picBox_2_1;
        private System.Windows.Forms.Label lbl_delay;
        private System.Windows.Forms.Button btn_delay_up;
        private System.Windows.Forms.Timer timer_display_V3;
    }
}