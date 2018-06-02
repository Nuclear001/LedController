namespace Arduino_Serial_Host_CS
{
    partial class SplashScreen
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.picbox_foregroud = new System.Windows.Forms.PictureBox();
            this.picbox_backgroud = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_foregroud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_backgroud)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(184, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "ColorMixer";
            // 
            // picbox_foregroud
            // 
            this.picbox_foregroud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picbox_foregroud.Location = new System.Drawing.Point(0, 275);
            this.picbox_foregroud.Name = "picbox_foregroud";
            this.picbox_foregroud.Size = new System.Drawing.Size(0, 25);
            this.picbox_foregroud.TabIndex = 1;
            this.picbox_foregroud.TabStop = false;
            // 
            // picbox_backgroud
            // 
            this.picbox_backgroud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(91)))));
            this.picbox_backgroud.Location = new System.Drawing.Point(0, 275);
            this.picbox_backgroud.Name = "picbox_backgroud";
            this.picbox_backgroud.Size = new System.Drawing.Size(600, 25);
            this.picbox_backgroud.TabIndex = 0;
            this.picbox_backgroud.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.picbox_foregroud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picbox_backgroud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_foregroud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_backgroud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbox_foregroud;
        private System.Windows.Forms.PictureBox picbox_backgroud;
    }
}