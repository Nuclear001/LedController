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
            this.cSlider_Blue = new ColorSlider.ColorSlider();
            this.cSlider_Green = new ColorSlider.ColorSlider();
            this.cSlider_Red = new ColorSlider.ColorSlider();
            this.btn_auto_refresh_rgbSlider = new System.Windows.Forms.Button();
            this.picBox_Color = new System.Windows.Forms.PictureBox();
            this.timer_colorRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Color)).BeginInit();
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
            // cSlider_Blue
            // 
            this.cSlider_Blue.BackColor = System.Drawing.Color.Transparent;
            this.cSlider_Blue.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.cSlider_Blue.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.cSlider_Blue.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.cSlider_Blue.ColorSchema = ColorSlider.ColorSlider.ColorSchemas.GreenColors;
            this.cSlider_Blue.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.cSlider_Blue.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.cSlider_Blue.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.cSlider_Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.cSlider_Blue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cSlider_Blue.LargeChange = ((uint)(5u));
            this.cSlider_Blue.Location = new System.Drawing.Point(573, 310);
            this.cSlider_Blue.Maximum = 255;
            this.cSlider_Blue.MouseEffects = false;
            this.cSlider_Blue.Name = "cSlider_Blue";
            this.cSlider_Blue.ScaleDivisions = 10;
            this.cSlider_Blue.ScaleSubDivisions = 5;
            this.cSlider_Blue.ShowDivisionsText = false;
            this.cSlider_Blue.ShowSmallScale = false;
            this.cSlider_Blue.Size = new System.Drawing.Size(338, 46);
            this.cSlider_Blue.SmallChange = ((uint)(1u));
            this.cSlider_Blue.TabIndex = 22;
            this.cSlider_Blue.ThumbInnerColor = System.Drawing.SystemColors.AppWorkspace;
            this.cSlider_Blue.ThumbOuterColor = System.Drawing.SystemColors.AppWorkspace;
            this.cSlider_Blue.ThumbPenColor = System.Drawing.SystemColors.AppWorkspace;
            this.cSlider_Blue.ThumbRoundRectSize = new System.Drawing.Size(1, 1);
            this.cSlider_Blue.ThumbSize = new System.Drawing.Size(10, 30);
            this.cSlider_Blue.TickAdd = 0F;
            this.cSlider_Blue.TickColor = System.Drawing.Color.White;
            this.cSlider_Blue.TickDivide = 0F;
            this.cSlider_Blue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.cSlider_Blue.Value = 40;
            // 
            // cSlider_Green
            // 
            this.cSlider_Green.BackColor = System.Drawing.Color.Transparent;
            this.cSlider_Green.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.cSlider_Green.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.cSlider_Green.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.cSlider_Green.ColorSchema = ColorSlider.ColorSlider.ColorSchemas.GreenColors;
            this.cSlider_Green.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(201)))), ((int)(((byte)(46)))));
            this.cSlider_Green.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(201)))), ((int)(((byte)(46)))));
            this.cSlider_Green.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(201)))), ((int)(((byte)(46)))));
            this.cSlider_Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.cSlider_Green.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cSlider_Green.LargeChange = ((uint)(5u));
            this.cSlider_Green.Location = new System.Drawing.Point(573, 258);
            this.cSlider_Green.Maximum = 255;
            this.cSlider_Green.MouseEffects = false;
            this.cSlider_Green.Name = "cSlider_Green";
            this.cSlider_Green.ScaleDivisions = 10;
            this.cSlider_Green.ScaleSubDivisions = 5;
            this.cSlider_Green.ShowDivisionsText = false;
            this.cSlider_Green.ShowSmallScale = false;
            this.cSlider_Green.Size = new System.Drawing.Size(338, 46);
            this.cSlider_Green.SmallChange = ((uint)(1u));
            this.cSlider_Green.TabIndex = 23;
            this.cSlider_Green.ThumbInnerColor = System.Drawing.SystemColors.AppWorkspace;
            this.cSlider_Green.ThumbOuterColor = System.Drawing.SystemColors.AppWorkspace;
            this.cSlider_Green.ThumbPenColor = System.Drawing.SystemColors.AppWorkspace;
            this.cSlider_Green.ThumbRoundRectSize = new System.Drawing.Size(1, 1);
            this.cSlider_Green.ThumbSize = new System.Drawing.Size(10, 30);
            this.cSlider_Green.TickAdd = 0F;
            this.cSlider_Green.TickColor = System.Drawing.Color.White;
            this.cSlider_Green.TickDivide = 0F;
            this.cSlider_Green.TickStyle = System.Windows.Forms.TickStyle.None;
            this.cSlider_Green.Value = 40;
            // 
            // cSlider_Red
            // 
            this.cSlider_Red.BackColor = System.Drawing.Color.Transparent;
            this.cSlider_Red.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.cSlider_Red.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.cSlider_Red.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.cSlider_Red.ColorSchema = ColorSlider.ColorSlider.ColorSchemas.GreenColors;
            this.cSlider_Red.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.cSlider_Red.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.cSlider_Red.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.cSlider_Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.cSlider_Red.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cSlider_Red.LargeChange = ((uint)(5u));
            this.cSlider_Red.Location = new System.Drawing.Point(573, 215);
            this.cSlider_Red.Maximum = 255;
            this.cSlider_Red.MouseEffects = false;
            this.cSlider_Red.Name = "cSlider_Red";
            this.cSlider_Red.ScaleDivisions = 10;
            this.cSlider_Red.ScaleSubDivisions = 5;
            this.cSlider_Red.ShowDivisionsText = false;
            this.cSlider_Red.ShowSmallScale = false;
            this.cSlider_Red.Size = new System.Drawing.Size(338, 46);
            this.cSlider_Red.SmallChange = ((uint)(1u));
            this.cSlider_Red.TabIndex = 24;
            this.cSlider_Red.ThumbInnerColor = System.Drawing.SystemColors.AppWorkspace;
            this.cSlider_Red.ThumbOuterColor = System.Drawing.SystemColors.AppWorkspace;
            this.cSlider_Red.ThumbPenColor = System.Drawing.SystemColors.AppWorkspace;
            this.cSlider_Red.ThumbRoundRectSize = new System.Drawing.Size(1, 1);
            this.cSlider_Red.ThumbSize = new System.Drawing.Size(10, 30);
            this.cSlider_Red.TickAdd = 0F;
            this.cSlider_Red.TickColor = System.Drawing.Color.White;
            this.cSlider_Red.TickDivide = 0F;
            this.cSlider_Red.TickStyle = System.Windows.Forms.TickStyle.None;
            this.cSlider_Red.Value = 40;
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
            // Basics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(975, 614);
            this.Controls.Add(this.picBox_Color);
            this.Controls.Add(this.btn_auto_refresh_rgbSlider);
            this.Controls.Add(this.cSlider_Red);
            this.Controls.Add(this.cSlider_Green);
            this.Controls.Add(this.cSlider_Blue);
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
        private ColorSlider.ColorSlider cSlider_Blue;
        private ColorSlider.ColorSlider cSlider_Green;
        private ColorSlider.ColorSlider cSlider_Red;
        private System.Windows.Forms.Button btn_auto_refresh_rgbSlider;
        private System.Windows.Forms.PictureBox picBox_Color;
        private System.Windows.Forms.Timer timer_colorRefresh;
    }
}