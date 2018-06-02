using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TopPanel
using System.Runtime.InteropServices;


namespace Arduino_Serial_Host_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //get the ButtonMarker to the right place
            ActiveButton(btn_Basic);
            //Change the "BigBox's" content
            newBigBoxForm(BasicsVar);
        }

        //Variables
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //End Variables

        //Form Variables
        Basics BasicsVar = new Basics();
        Advanced AdvancedVar = new Advanced();
        Settings SettingsVar = new Settings();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TopPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ActiveButton(Button newButton)
        {
            picBox_Active.Height = newButton.Height;
            picBox_Active.Top = newButton.Top;
        }

        private void newBigBoxForm(Form FormX)
        {
            panel_Big.Controls.Clear();
            FormX.TopLevel = false;

            panel_Big.Controls.Add(FormX);
            FormX.Show();
        }

        private void btn_exit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_basics_click(object sender, EventArgs e)
        {
            //get the ButtonMarker to the right place
            ActiveButton(btn_Basic);
            //Change the "BigBox's" content
            newBigBoxForm(BasicsVar);
        }

        private void btn_advanced_click(object sender, EventArgs e)
        {
            //get the ButtonMarker to the right place
            ActiveButton(btn_Advanced);
            //Change the "BigBox's" content
            newBigBoxForm(AdvancedVar);
        }

        private void btn_Settings_click(object sender, EventArgs e)
        {
            //get the ButtonMarker to the right place
            ActiveButton(btn_Settings);
            //Change the "BigBox's" content
            newBigBoxForm(SettingsVar);
        }


        private void btn_unknown_click(object sender, EventArgs e)
        {
            //get the ButtonMarker to the right place
            ActiveButton(btn_unknown);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
