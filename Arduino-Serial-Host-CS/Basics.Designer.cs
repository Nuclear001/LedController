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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_DESK = new System.Windows.Forms.Button();
            this.btn_PC = new System.Windows.Forms.Button();
            this.Arduino_Port = new System.IO.Ports.SerialPort(this.components);
            this.lbl_hue = new System.Windows.Forms.Label();
            this.lbl_saturation = new System.Windows.Forms.Label();
            this.lbl_brightness = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar_saturation = new System.Windows.Forms.TrackBar();
            this.trackBar_brightness = new System.Windows.Forms.TrackBar();
            this.btn_auto_refresh_rgbSlider = new System.Windows.Forms.Button();
            this.picBox_Color = new System.Windows.Forms.PictureBox();
            this.timer_colorRefresh = new System.Windows.Forms.Timer(this.components);
            this.cSlider_Red = new System.Windows.Forms.TrackBar();
            this.cSlider_Green = new System.Windows.Forms.TrackBar();
            this.cSlider_Blue = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSlider_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSlider_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSlider_Blue)).BeginInit();
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
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(337, 62);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
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
            // lbl_hue
            // 
            this.lbl_hue.AutoSize = true;
            this.lbl_hue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hue.Location = new System.Drawing.Point(685, 128);
            this.lbl_hue.Name = "lbl_hue";
            this.lbl_hue.Size = new System.Drawing.Size(46, 24);
            this.lbl_hue.TabIndex = 13;
            this.lbl_hue.Text = "Hue";
            // 
            // lbl_saturation
            // 
            this.lbl_saturation.AutoSize = true;
            this.lbl_saturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saturation.Location = new System.Drawing.Point(685, 152);
            this.lbl_saturation.Name = "lbl_saturation";
            this.lbl_saturation.Size = new System.Drawing.Size(93, 24);
            this.lbl_saturation.TabIndex = 14;
            this.lbl_saturation.Text = "Saturation";
            // 
            // lbl_brightness
            // 
            this.lbl_brightness.AutoSize = true;
            this.lbl_brightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brightness.Location = new System.Drawing.Point(685, 176);
            this.lbl_brightness.Name = "lbl_brightness";
            this.lbl_brightness.Size = new System.Drawing.Size(98, 24);
            this.lbl_brightness.TabIndex = 15;
            this.lbl_brightness.Text = "Brightness";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Brightness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(569, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Saturation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hue";
            // 
            // trackBar_saturation
            // 
            this.trackBar_saturation.Location = new System.Drawing.Point(573, 362);
            this.trackBar_saturation.Maximum = 1000;
            this.trackBar_saturation.Name = "trackBar_saturation";
            this.trackBar_saturation.Size = new System.Drawing.Size(338, 45);
            this.trackBar_saturation.TabIndex = 19;
            // 
            // trackBar_brightness
            // 
            this.trackBar_brightness.Location = new System.Drawing.Point(573, 413);
            this.trackBar_brightness.Maximum = 1000;
            this.trackBar_brightness.Name = "trackBar_brightness";
            this.trackBar_brightness.Size = new System.Drawing.Size(338, 45);
            this.trackBar_brightness.TabIndex = 21;
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
            this.picBox_Color.Location = new System.Drawing.Point(573, 72);
            this.picBox_Color.Name = "picBox_Color";
            this.picBox_Color.Size = new System.Drawing.Size(171, 54);
            this.picBox_Color.TabIndex = 28;
            this.picBox_Color.TabStop = false;
            // 
            // timer_colorRefresh
            // 
            this.timer_colorRefresh.Tick += new System.EventHandler(this.timer_colorRefresh_Tick);
            // 
            // cSlider_Red
            // 
            this.cSlider_Red.Location = new System.Drawing.Point(513, 219);
            this.cSlider_Red.Maximum = 255;
            this.cSlider_Red.Name = "cSlider_Red";
            this.cSlider_Red.Size = new System.Drawing.Size(398, 45);
            this.cSlider_Red.TabIndex = 29;
            // 
            // cSlider_Green
            // 
            this.cSlider_Green.Location = new System.Drawing.Point(513, 270);
            this.cSlider_Green.Maximum = 255;
            this.cSlider_Green.Name = "cSlider_Green";
            this.cSlider_Green.Size = new System.Drawing.Size(398, 45);
            this.cSlider_Green.TabIndex = 30;
            // 
            // cSlider_Blue
            // 
            this.cSlider_Blue.Location = new System.Drawing.Point(513, 321);
            this.cSlider_Blue.Maximum = 255;
            this.cSlider_Blue.Name = "cSlider_Blue";
            this.cSlider_Blue.Size = new System.Drawing.Size(398, 45);
            this.cSlider_Blue.TabIndex = 31;
            // 
            // Basics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(975, 614);
            this.Controls.Add(this.cSlider_Blue);
            this.Controls.Add(this.cSlider_Green);
            this.Controls.Add(this.cSlider_Red);
            this.Controls.Add(this.picBox_Color);
            this.Controls.Add(this.btn_auto_refresh_rgbSlider);
            this.Controls.Add(this.trackBar_brightness);
            this.Controls.Add(this.trackBar_saturation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_brightness);
            this.Controls.Add(this.lbl_saturation);
            this.Controls.Add(this.lbl_hue);
            this.Controls.Add(this.btn_PC);
            this.Controls.Add(this.btn_DESK);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_connect);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Basics";
            this.Text = "Basics";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSlider_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSlider_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSlider_Blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_DESK;
        private System.Windows.Forms.Button btn_PC;
        private System.IO.Ports.SerialPort Arduino_Port;
        private System.Windows.Forms.Label lbl_hue;
        private System.Windows.Forms.Label lbl_saturation;
        private System.Windows.Forms.Label lbl_brightness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar_saturation;
        private System.Windows.Forms.TrackBar trackBar_brightness;
        private System.Windows.Forms.Button btn_auto_refresh_rgbSlider;
        private System.Windows.Forms.PictureBox picBox_Color;
        private System.Windows.Forms.Timer timer_colorRefresh;
        private System.Windows.Forms.TrackBar cSlider_Red;
        private System.Windows.Forms.TrackBar cSlider_Green;
        private System.Windows.Forms.TrackBar cSlider_Blue;
    }
}