namespace Arduino_Serial_Host_CS
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_unknown = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Advanced = new System.Windows.Forms.Button();
            this.btn_Basic = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.picbox_Icon = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_Headline = new System.Windows.Forms.Label();
            this.panel_left = new System.Windows.Forms.Panel();
            this.picBox_Active = new System.Windows.Forms.PictureBox();
            this.panel_Big = new System.Windows.Forms.Panel();
            this.ArduinoPort = new System.IO.Ports.SerialPort(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Icon)).BeginInit();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Active)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_unknown
            // 
            this.btn_unknown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_unknown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_unknown.Location = new System.Drawing.Point(12, 434);
            this.btn_unknown.Name = "btn_unknown";
            this.btn_unknown.Size = new System.Drawing.Size(200, 88);
            this.btn_unknown.TabIndex = 5;
            this.btn_unknown.Text = "???";
            this.btn_unknown.UseVisualStyleBackColor = true;
            this.btn_unknown.Click += new System.EventHandler(this.btn_unknown_click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Location = new System.Drawing.Point(12, 302);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(200, 88);
            this.btn_Settings.TabIndex = 4;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_click);
            // 
            // btn_Advanced
            // 
            this.btn_Advanced.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Advanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Advanced.Location = new System.Drawing.Point(12, 170);
            this.btn_Advanced.Name = "btn_Advanced";
            this.btn_Advanced.Size = new System.Drawing.Size(200, 88);
            this.btn_Advanced.TabIndex = 2;
            this.btn_Advanced.Text = "Advanced";
            this.btn_Advanced.UseVisualStyleBackColor = true;
            this.btn_Advanced.Click += new System.EventHandler(this.btn_advanced_click);
            // 
            // btn_Basic
            // 
            this.btn_Basic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Basic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Basic.Location = new System.Drawing.Point(12, 38);
            this.btn_Basic.Name = "btn_Basic";
            this.btn_Basic.Size = new System.Drawing.Size(200, 88);
            this.btn_Basic.TabIndex = 0;
            this.btn_Basic.Text = "Basics";
            this.btn_Basic.UseVisualStyleBackColor = true;
            this.btn_Basic.Click += new System.EventHandler(this.btn_basics_click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.TopPanel.Controls.Add(this.picbox_Icon);
            this.TopPanel.Controls.Add(this.btn_exit);
            this.TopPanel.Controls.Add(this.lbl_Headline);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1200, 30);
            this.TopPanel.TabIndex = 2;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // picbox_Icon
            // 
            this.picbox_Icon.BackgroundImage = global::Arduino_Serial_Host_CS.Properties.Resources.Icon_ColorMixer;
            this.picbox_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbox_Icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.picbox_Icon.Location = new System.Drawing.Point(0, 0);
            this.picbox_Icon.Name = "picbox_Icon";
            this.picbox_Icon.Size = new System.Drawing.Size(36, 30);
            this.picbox_Icon.TabIndex = 1;
            this.picbox_Icon.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::Arduino_Serial_Host_CS.Properties.Resources.Close_X;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(1164, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(36, 30);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_click);
            // 
            // lbl_Headline
            // 
            this.lbl_Headline.AutoSize = true;
            this.lbl_Headline.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Headline.Location = new System.Drawing.Point(42, 0);
            this.lbl_Headline.Name = "lbl_Headline";
            this.lbl_Headline.Size = new System.Drawing.Size(148, 33);
            this.lbl_Headline.TabIndex = 0;
            this.lbl_Headline.Text = "ColorMixer";
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.panel_left.Controls.Add(this.btn_unknown);
            this.panel_left.Controls.Add(this.btn_Basic);
            this.panel_left.Controls.Add(this.picBox_Active);
            this.panel_left.Controls.Add(this.btn_Advanced);
            this.panel_left.Controls.Add(this.btn_Settings);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 30);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(231, 620);
            this.panel_left.TabIndex = 6;
            // 
            // picBox_Active
            // 
            this.picBox_Active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.picBox_Active.Location = new System.Drawing.Point(215, 38);
            this.picBox_Active.Name = "picBox_Active";
            this.picBox_Active.Size = new System.Drawing.Size(10, 88);
            this.picBox_Active.TabIndex = 1;
            this.picBox_Active.TabStop = false;
            // 
            // panel_Big
            // 
            this.panel_Big.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Big.Location = new System.Drawing.Point(231, 30);
            this.panel_Big.Name = "panel_Big";
            this.panel_Big.Size = new System.Drawing.Size(969, 620);
            this.panel_Big.TabIndex = 7;
            // 
            // ArduinoPort
            // 
            this.ArduinoPort.PortName = "COM3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(71)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panel_Big);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Icon)).EndInit();
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Active)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_unknown;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Advanced;
        private System.Windows.Forms.Button btn_Basic;
        private System.Windows.Forms.PictureBox picBox_Active;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Label lbl_Headline;
        private System.Windows.Forms.Panel panel_Big;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox picbox_Icon;
        private System.IO.Ports.SerialPort ArduinoPort;
    }
}

