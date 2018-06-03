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
            listView1.Items.Clear();
            foreach (string port in ports)
            {
                listView1.Items.Add(port);

                Console.WriteLine(port);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //int items = listView1.SelectedItems.ToString;
        }
    }
}
