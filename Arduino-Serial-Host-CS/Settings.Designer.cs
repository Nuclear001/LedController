namespace Arduino_Serial_Host_CS
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
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_refresh_Com = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(91)))));
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_save.Location = new System.Drawing.Point(12, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(212, 77);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(91)))));
            this.btn_load.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_load.Location = new System.Drawing.Point(12, 107);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(212, 77);
            this.btn_load.TabIndex = 4;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(862, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(101, 172);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btn_refresh_Com
            // 
            this.btn_refresh_Com.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(91)))));
            this.btn_refresh_Com.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_refresh_Com.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh_Com.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_refresh_Com.Location = new System.Drawing.Point(644, 12);
            this.btn_refresh_Com.Name = "btn_refresh_Com";
            this.btn_refresh_Com.Size = new System.Drawing.Size(212, 77);
            this.btn_refresh_Com.TabIndex = 6;
            this.btn_refresh_Com.Text = "refresh list";
            this.btn_refresh_Com.UseVisualStyleBackColor = false;
            this.btn_refresh_Com.Click += new System.EventHandler(this.btn_refresh_Com_Click);
            // 
            // Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(975, 614);
            this.Controls.Add(this.btn_refresh_Com);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_save);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_refresh_Com;
    }
}