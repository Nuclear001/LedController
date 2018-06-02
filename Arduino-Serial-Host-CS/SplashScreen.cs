using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Serial_Host_CS
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picbox_foregroud.Width < picbox_backgroud.Width)
            {
                picbox_foregroud.Width += 5;

            }
            else
            {
                this.BringToFront();
                this.Focus();


                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));

                t.Start();

               
                Close();
            }

        }

        public static void ThreadProc()

        {

            Application.Run(new Form1());

        }
    }
}

