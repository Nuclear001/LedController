namespace Arduino_Serial_Host_CS
{
    partial class Basics
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
            this.btn_DESK = new System.Windows.Forms.Button();
            this.btn_PC = new System.Windows.Forms.Button();
            this.Arduino_Port = new System.IO.Ports.SerialPort(this.components);
            this.lbl_hue = new System.Windows.Forms.Label();
            this.lbl_saturation = new System.Windows.Forms.Label();
            this.lbl_brightness = new System.Windows.Forms.Label();
            this.lbl_brightness_info = new System.Windows.Forms.Label();
            this.lbl_saturation_info = new System.Windows.Forms.Label();
            this.lbl_hue_info = new System.Windows.Forms.Label();
            this.slider_saturation = new System.Windows.Forms.TrackBar();
            this.slider_brightness = new System.Windows.Forms.TrackBar();
            this.btn_auto_refresh_rgbSlider = new System.Windows.Forms.Button();
            this.picBox_Color = new System.Windows.Forms.PictureBox();
            this.timer_colorRefresh = new System.Windows.Forms.Timer(this.components);
            this.slider_red = new System.Windows.Forms.TrackBar();
            this.slider_green = new System.Windows.Forms.TrackBar();
            this.slider_blue = new System.Windows.Forms.TrackBar();
            this.btn_delay_down = new System.Windows.Forms.Button();
            this.btn_delay_up = new System.Windows.Forms.Button();
            this.lbl_delay = new System.Windows.Forms.Label();
            this.lbl_blue_info = new System.Windows.Forms.Label();
            this.lbl_green_info = new System.Windows.Forms.Label();
            this.lbl_red_info = new System.Windows.Forms.Label();
            this.lbl_blue = new System.Windows.Forms.Label();
            this.lbl_green = new System.Windows.Forms.Label();
            this.lbl_red = new System.Windows.Forms.Label();
            this.slider_hue = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.slider_saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_hue)).BeginInit();
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
            // btn_DESK
            // 
            this.btn_DESK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(91)))));
            this.btn_DESK.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_DESK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DESK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_DESK.ForeColor = System.Drawing.Color.Gray;
            this.btn_DESK.Location = new System.Drawing.Point(276, 120);
            this.btn_DESK.Name = "btn_DESK";
            this.btn_DESK.Size = new System.Drawing.Size(145, 41);
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
            this.btn_PC.Location = new System.Drawing.Point(276, 168);
            this.btn_PC.Name = "btn_PC";
            this.btn_PC.Size = new System.Drawing.Size(145, 41);
            this.btn_PC.TabIndex = 7;
            this.btn_PC.Text = "PC";
            this.btn_PC.UseVisualStyleBackColor = false;
            this.btn_PC.Click += new System.EventHandler(this.btn_PC_Click);
            // 
            // Arduino_Port
            // 
            this.Arduino_Port.PortName = "COM3";
            // 
            // lbl_hue
            // 
            this.lbl_hue.AutoSize = true;
            this.lbl_hue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hue.Location = new System.Drawing.Point(590, 440);
            this.lbl_hue.Name = "lbl_hue";
            this.lbl_hue.Size = new System.Drawing.Size(20, 24);
            this.lbl_hue.TabIndex = 13;
            this.lbl_hue.Text = "0";
            // 
            // lbl_saturation
            // 
            this.lbl_saturation.AutoSize = true;
            this.lbl_saturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saturation.Location = new System.Drawing.Point(590, 491);
            this.lbl_saturation.Name = "lbl_saturation";
            this.lbl_saturation.Size = new System.Drawing.Size(20, 24);
            this.lbl_saturation.TabIndex = 14;
            this.lbl_saturation.Text = "1";
            // 
            // lbl_brightness
            // 
            this.lbl_brightness.AutoSize = true;
            this.lbl_brightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brightness.Location = new System.Drawing.Point(590, 542);
            this.lbl_brightness.Name = "lbl_brightness";
            this.lbl_brightness.Size = new System.Drawing.Size(35, 24);
            this.lbl_brightness.TabIndex = 15;
            this.lbl_brightness.Text = "0.5";
            // 
            // lbl_brightness_info
            // 
            this.lbl_brightness_info.AutoSize = true;
            this.lbl_brightness_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brightness_info.Location = new System.Drawing.Point(485, 542);
            this.lbl_brightness_info.Name = "lbl_brightness_info";
            this.lbl_brightness_info.Size = new System.Drawing.Size(86, 24);
            this.lbl_brightness_info.TabIndex = 18;
            this.lbl_brightness_info.Text = "Helligkeit";
            // 
            // lbl_saturation_info
            // 
            this.lbl_saturation_info.AutoSize = true;
            this.lbl_saturation_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saturation_info.Location = new System.Drawing.Point(485, 491);
            this.lbl_saturation_info.Name = "lbl_saturation_info";
            this.lbl_saturation_info.Size = new System.Drawing.Size(88, 24);
            this.lbl_saturation_info.TabIndex = 17;
            this.lbl_saturation_info.Text = "Sättigung";
            // 
            // lbl_hue_info
            // 
            this.lbl_hue_info.AutoSize = true;
            this.lbl_hue_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hue_info.Location = new System.Drawing.Point(485, 440);
            this.lbl_hue_info.Name = "lbl_hue_info";
            this.lbl_hue_info.Size = new System.Drawing.Size(46, 24);
            this.lbl_hue_info.TabIndex = 16;
            this.lbl_hue_info.Text = "Hue";
            // 
            // slider_saturation
            // 
            this.slider_saturation.Location = new System.Drawing.Point(651, 491);
            this.slider_saturation.Maximum = 1000;
            this.slider_saturation.Name = "slider_saturation";
            this.slider_saturation.Size = new System.Drawing.Size(312, 45);
            this.slider_saturation.TabIndex = 19;
            this.slider_saturation.Scroll += new System.EventHandler(this.slider_saturation_Scroll);
            // 
            // slider_brightness
            // 
            this.slider_brightness.Location = new System.Drawing.Point(651, 542);
            this.slider_brightness.Maximum = 1000;
            this.slider_brightness.Name = "slider_brightness";
            this.slider_brightness.Size = new System.Drawing.Size(312, 45);
            this.slider_brightness.TabIndex = 21;
            this.slider_brightness.Scroll += new System.EventHandler(this.slider_brightness_Scroll);
            // 
            // btn_auto_refresh_rgbSlider
            // 
            this.btn_auto_refresh_rgbSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(91)))));
            this.btn_auto_refresh_rgbSlider.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_auto_refresh_rgbSlider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_auto_refresh_rgbSlider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_auto_refresh_rgbSlider.ForeColor = System.Drawing.Color.Gray;
            this.btn_auto_refresh_rgbSlider.Location = new System.Drawing.Point(12, 120);
            this.btn_auto_refresh_rgbSlider.Name = "btn_auto_refresh_rgbSlider";
            this.btn_auto_refresh_rgbSlider.Size = new System.Drawing.Size(212, 89);
            this.btn_auto_refresh_rgbSlider.TabIndex = 26;
            this.btn_auto_refresh_rgbSlider.Text = "Automatisch Schieber aktualisieren";
            this.btn_auto_refresh_rgbSlider.UseVisualStyleBackColor = false;
            this.btn_auto_refresh_rgbSlider.Click += new System.EventHandler(this.btn_auto_refresh_rgbSlider_Click);
            // 
            // picBox_Color
            // 
            this.picBox_Color.Location = new System.Drawing.Point(818, 120);
            this.picBox_Color.Name = "picBox_Color";
            this.picBox_Color.Size = new System.Drawing.Size(145, 89);
            this.picBox_Color.TabIndex = 28;
            this.picBox_Color.TabStop = false;
            // 
            // timer_colorRefresh
            // 
            this.timer_colorRefresh.Tick += new System.EventHandler(this.timer_colorRefresh_Tick);
            // 
            // slider_red
            // 
            this.slider_red.Location = new System.Drawing.Point(651, 248);
            this.slider_red.Maximum = 255;
            this.slider_red.Name = "slider_red";
            this.slider_red.Size = new System.Drawing.Size(312, 45);
            this.slider_red.TabIndex = 29;
            this.slider_red.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_red.Scroll += new System.EventHandler(this.cSlider_Red_Scroll);
            // 
            // slider_green
            // 
            this.slider_green.Location = new System.Drawing.Point(651, 299);
            this.slider_green.Maximum = 255;
            this.slider_green.Name = "slider_green";
            this.slider_green.Size = new System.Drawing.Size(312, 45);
            this.slider_green.TabIndex = 30;
            this.slider_green.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_green.Scroll += new System.EventHandler(this.slider_green_Scroll);
            // 
            // slider_blue
            // 
            this.slider_blue.Location = new System.Drawing.Point(651, 350);
            this.slider_blue.Maximum = 255;
            this.slider_blue.Name = "slider_blue";
            this.slider_blue.Size = new System.Drawing.Size(312, 45);
            this.slider_blue.TabIndex = 31;
            this.slider_blue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_blue.Scroll += new System.EventHandler(this.slider_blue_Scroll);
            // 
            // btn_delay_down
            // 
            this.btn_delay_down.BackgroundImage = global::Arduino_Serial_Host_CS.Properties.Resources.delay_down_button;
            this.btn_delay_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delay_down.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_delay_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delay_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delay_down.Location = new System.Drawing.Point(373, 21);
            this.btn_delay_down.Name = "btn_delay_down";
            this.btn_delay_down.Size = new System.Drawing.Size(48, 45);
            this.btn_delay_down.TabIndex = 34;
            this.btn_delay_down.UseVisualStyleBackColor = true;
            // 
            // btn_delay_up
            // 
            this.btn_delay_up.BackgroundImage = global::Arduino_Serial_Host_CS.Properties.Resources.delay_up_button;
            this.btn_delay_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delay_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delay_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delay_up.Location = new System.Drawing.Point(319, 21);
            this.btn_delay_up.Name = "btn_delay_up";
            this.btn_delay_up.Size = new System.Drawing.Size(48, 45);
            this.btn_delay_up.TabIndex = 33;
            this.btn_delay_up.UseVisualStyleBackColor = true;
            // 
            // lbl_delay
            // 
            this.lbl_delay.AutoSize = true;
            this.lbl_delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_delay.Location = new System.Drawing.Point(256, 31);
            this.lbl_delay.Name = "lbl_delay";
            this.lbl_delay.Size = new System.Drawing.Size(60, 25);
            this.lbl_delay.TabIndex = 32;
            this.lbl_delay.Text = "1000";
            // 
            // lbl_blue_info
            // 
            this.lbl_blue_info.AutoSize = true;
            this.lbl_blue_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_blue_info.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_blue_info.Location = new System.Drawing.Point(533, 350);
            this.lbl_blue_info.Name = "lbl_blue_info";
            this.lbl_blue_info.Size = new System.Drawing.Size(47, 24);
            this.lbl_blue_info.TabIndex = 40;
            this.lbl_blue_info.Text = "Blau";
            // 
            // lbl_green_info
            // 
            this.lbl_green_info.AutoSize = true;
            this.lbl_green_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_green_info.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbl_green_info.Location = new System.Drawing.Point(533, 299);
            this.lbl_green_info.Name = "lbl_green_info";
            this.lbl_green_info.Size = new System.Drawing.Size(52, 24);
            this.lbl_green_info.TabIndex = 39;
            this.lbl_green_info.Text = "Grün";
            // 
            // lbl_red_info
            // 
            this.lbl_red_info.AutoSize = true;
            this.lbl_red_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_red_info.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_red_info.Location = new System.Drawing.Point(533, 248);
            this.lbl_red_info.Name = "lbl_red_info";
            this.lbl_red_info.Size = new System.Drawing.Size(38, 24);
            this.lbl_red_info.TabIndex = 38;
            this.lbl_red_info.Text = "Rot";
            // 
            // lbl_blue
            // 
            this.lbl_blue.AutoSize = true;
            this.lbl_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_blue.Location = new System.Drawing.Point(625, 350);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(20, 24);
            this.lbl_blue.TabIndex = 37;
            this.lbl_blue.Text = "0";
            // 
            // lbl_green
            // 
            this.lbl_green.AutoSize = true;
            this.lbl_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_green.Location = new System.Drawing.Point(625, 299);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(20, 24);
            this.lbl_green.TabIndex = 36;
            this.lbl_green.Text = "0";
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_red.Location = new System.Drawing.Point(625, 248);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(20, 24);
            this.lbl_red.TabIndex = 35;
            this.lbl_red.Text = "0";
            // 
            // slider_hue
            // 
            this.slider_hue.Location = new System.Drawing.Point(651, 440);
            this.slider_hue.Maximum = 360;
            this.slider_hue.Name = "slider_hue";
            this.slider_hue.Size = new System.Drawing.Size(312, 45);
            this.slider_hue.TabIndex = 41;
            this.slider_hue.Scroll += new System.EventHandler(this.slider_hue_Scroll);
            // 
            // Basics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(975, 614);
            this.Controls.Add(this.slider_hue);
            this.Controls.Add(this.lbl_blue_info);
            this.Controls.Add(this.lbl_green_info);
            this.Controls.Add(this.lbl_red_info);
            this.Controls.Add(this.lbl_blue);
            this.Controls.Add(this.lbl_green);
            this.Controls.Add(this.lbl_red);
            this.Controls.Add(this.btn_delay_down);
            this.Controls.Add(this.btn_delay_up);
            this.Controls.Add(this.lbl_delay);
            this.Controls.Add(this.slider_blue);
            this.Controls.Add(this.slider_green);
            this.Controls.Add(this.slider_red);
            this.Controls.Add(this.picBox_Color);
            this.Controls.Add(this.btn_auto_refresh_rgbSlider);
            this.Controls.Add(this.slider_brightness);
            this.Controls.Add(this.slider_saturation);
            this.Controls.Add(this.lbl_brightness_info);
            this.Controls.Add(this.lbl_saturation_info);
            this.Controls.Add(this.lbl_hue_info);
            this.Controls.Add(this.lbl_brightness);
            this.Controls.Add(this.lbl_saturation);
            this.Controls.Add(this.lbl_hue);
            this.Controls.Add(this.btn_PC);
            this.Controls.Add(this.btn_DESK);
            this.Controls.Add(this.btn_connect);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Basics";
            this.Text = "Basics";
            ((System.ComponentModel.ISupportInitialize)(this.slider_saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_hue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_DESK;
        private System.Windows.Forms.Button btn_PC;
        private System.IO.Ports.SerialPort Arduino_Port;
        private System.Windows.Forms.Label lbl_hue;
        private System.Windows.Forms.Label lbl_saturation;
        private System.Windows.Forms.Label lbl_brightness;
        private System.Windows.Forms.Label lbl_brightness_info;
        private System.Windows.Forms.Label lbl_saturation_info;
        private System.Windows.Forms.Label lbl_hue_info;
        private System.Windows.Forms.TrackBar slider_saturation;
        private System.Windows.Forms.TrackBar slider_brightness;
        private System.Windows.Forms.Button btn_auto_refresh_rgbSlider;
        private System.Windows.Forms.PictureBox picBox_Color;
        private System.Windows.Forms.Timer timer_colorRefresh;
        private System.Windows.Forms.TrackBar slider_red;
        private System.Windows.Forms.TrackBar slider_green;
        private System.Windows.Forms.TrackBar slider_blue;
        private System.Windows.Forms.Button btn_delay_down;
        private System.Windows.Forms.Button btn_delay_up;
        private System.Windows.Forms.Label lbl_delay;
        private System.Windows.Forms.Label lbl_blue_info;
        private System.Windows.Forms.Label lbl_green_info;
        private System.Windows.Forms.Label lbl_red_info;
        private System.Windows.Forms.Label lbl_blue;
        private System.Windows.Forms.Label lbl_green;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.TrackBar slider_hue;
    }
}