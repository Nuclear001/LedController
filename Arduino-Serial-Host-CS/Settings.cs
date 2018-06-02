using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Serial_Host_CS
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btn_refresh_Com_Click(object sender, EventArgs e)
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            flowLayoutPanel1.Controls.Clear();
            foreach (string port in ports)
            {
                Label lbl_COM = new Label();
                lbl_COM.Name = "textBox1" + port;
                lbl_COM.Text = port;
                lbl_COM.Tag = port;
                flowLayoutPanel1.Controls.Add(lbl_COM);

                Console.WriteLine(port);
            }
        }
    }
}
