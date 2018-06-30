using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using static Arduino_Serial_Host_CS.Class1;
using System.IO;


namespace Arduino_Serial_Host_CS
{
    public partial class Basics : Form
    {


        public Basics()
        {
            InitializeComponent();
        }


        int fadeSpeed = 1000;
        bool buttonmode = false;




        bool PCEnabled = false;
        bool DESKEnabled = false;

        //active color space
        string activeColorSpace = "RGB";

        //the selected color
        Color color;

        public static Color FromAhsb(int alpha, float hue, float saturation, float brightness)
        {
            if (0 > alpha
                || 255 < alpha)
            {
                throw new ArgumentOutOfRangeException(
                    "alpha",
                    alpha,
                    "Value must be within a range of 0 - 255.");
            }

            if (0f > hue
                || 360f < hue)
            {
                throw new ArgumentOutOfRangeException(
                    "hue",
                    hue,
                    "Value must be within a range of 0 - 360.");
            }

            if (0f > saturation
                || 1f < saturation)
            {
                throw new ArgumentOutOfRangeException(
                    "saturation",
                    saturation,
                    "Value must be within a range of 0 - 1.");
            }

            if (0f > brightness
                || 1f < brightness)
            {
                throw new ArgumentOutOfRangeException(
                    "brightness",
                    brightness,
                    "Value must be within a range of 0 - 1.");
            }

            if (0 == saturation)
            {
                return Color.FromArgb(
                                    alpha,
                                    Convert.ToInt32(brightness * 255),
                                    Convert.ToInt32(brightness * 255),
                                    Convert.ToInt32(brightness * 255));
            }

            float fMax, fMid, fMin;
            int iSextant, iMax, iMid, iMin;

            if (0.5 < brightness)
            {
                fMax = brightness - (brightness * saturation) + saturation;
                fMin = brightness + (brightness * saturation) - saturation;
            }
            else
            {
                fMax = brightness + (brightness * saturation);
                fMin = brightness - (brightness * saturation);
            }

            iSextant = (int)Math.Floor(hue / 60f);
            if (300f <= hue)
            {
                hue -= 360f;
            }

            hue /= 60f;
            hue -= 2f * (float)Math.Floor(((iSextant + 1f) % 6f) / 2f);
            if (0 == iSextant % 2)
            {
                fMid = (hue * (fMax - fMin)) + fMin;
            }
            else
            {
                fMid = fMin - (hue * (fMax - fMin));
            }

            iMax = Convert.ToInt32(fMax * 255);
            iMid = Convert.ToInt32(fMid * 255);
            iMin = Convert.ToInt32(fMin * 255);

            switch (iSextant)
            {
                case 1:
                    return Color.FromArgb(alpha, iMid, iMax, iMin);
                case 2:
                    return Color.FromArgb(alpha, iMin, iMax, iMid);
                case 3:
                    return Color.FromArgb(alpha, iMin, iMid, iMax);
                case 4:
                    return Color.FromArgb(alpha, iMid, iMin, iMax);
                case 5:
                    return Color.FromArgb(alpha, iMax, iMin, iMid);
                default:
                    return Color.FromArgb(alpha, iMax, iMid, iMin);
            }
        }


        private void btn_DESK_Click(object sender, EventArgs e)
        {
            if (DESKEnabled == true)
            {
                //Disabling
                DESKEnabled = false;
                disablingButton(btn_DESK);
            }
            else
            {
                //Enabling
                DESKEnabled = true;
                enablingButton(btn_DESK);
            }
        }

        private void btn_PC_Click(object sender, EventArgs e)
        {
            if (PCEnabled == true)
            {
                //Disabling
                PCEnabled = false;
                disablingButton(btn_PC);
            }
            else
            {
                //Enabling
                PCEnabled = true;
                enablingButton(btn_PC);
            }
        }
        private void enablingButton(Button target)
        {
            target.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            target.ForeColor = Color.White;
        }
        private void disablingButton(Button target)
        {
            target.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            target.ForeColor = Color.Gray;
        }

        private void btn_connect_click(object sender, EventArgs e)
        {
            if (buttonmode == true)
            {
                //DISABLED
                try
                {
                    Arduino_Port.Close();
                    buttonmode = false;
                    btn_connect.BackgroundImage = Properties.Resources.Power_Off;
                    btn_connect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(247, 16, 0);
                }
                catch (Exception)
                {
                    MessageBox.Show("can't close the port");
                }

            }
            else
            {
                //ACTIVATED
                try
                {
                    Arduino_Port.Open();
                    buttonmode = true;
                    btn_connect.BackgroundImage = Properties.Resources.Power_On;
                    btn_connect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 192, 192);
                }
                catch (Exception)
                {
                    MessageBox.Show("port is already in use!!!");
                }

            }
        }


        public void setColorWithTime(Color color, int time)
        {
            if (time < 305)
            {
            }
            else
            {
                time -= 50;
            }

            if (PCEnabled == true && DESKEnabled == false)
            {
                Arduino_Port.WriteLine("SET PC " + color.R + " " + color.G + " " + color.B + " " + color.R + " " + color.G + " " + color.B + " " + Convert.ToString(time) + " \n");
                Console.WriteLine("SET PC " + color.R + " " + color.G + " " + color.B + " " + color.R + " " + color.G + " " + color.B + " " + Convert.ToString(time) + " \n");
            }
            if (PCEnabled == false && DESKEnabled == true)
            {
                Arduino_Port.WriteLine("SET TABLE " + color.R + " " + color.G + " " + color.B + " " + color.R + " " + color.G + " " + color.B + " " + Convert.ToString(time) + " \n");
                Console.WriteLine("SET TABLE " + color.R + " " + color.G + " " + color.B + " " + color.R + " " + color.G + " " + color.B + " " + Convert.ToString(time) + " \n");
            }
            if (PCEnabled == true && DESKEnabled == true)
            {
                Arduino_Port.WriteLine("SET BOTH " + color.R + " " + color.G + " " + color.B + " " + color.R + " " + color.G + " " + color.B + " " + Convert.ToString(time) + " \n");
                Console.WriteLine("SET BOTH " + color.R + " " + color.G + " " + color.B + " " + color.R + " " + color.G + " " + color.B + " " + Convert.ToString(time) + " \n");
            }
        }



        private void btn_auto_refresh_rgbSlider_Click(object sender, EventArgs e)
        {
            if (Arduino_Port.IsOpen)
            {
                if (timer_colorRefresh.Enabled == true)
                {
                    disablingButton(btn_auto_refresh_rgbSlider);
                    timer_colorRefresh.Stop();
                }
                else
                {
                    enablingButton(btn_auto_refresh_rgbSlider);
                    timer_colorRefresh.Start();
                }
            }
        }

        private void timer_colorRefresh_Tick(object sender, EventArgs e)
        {
            if (Arduino_Port.IsOpen)
            {
                timer_colorRefresh.Interval = fadeSpeed + 10;

                setColorWithTime(color, fadeSpeed);
            }
        }
        private void colorCalc()
        {
            //decide which Color is choosen (RGB or HSB)
            if (activeColorSpace == "RGB")
            {
                //get the color
                color = Color.FromArgb(slider_red.Value, slider_green.Value, slider_blue.Value);
                //set other sliders
                slider_hue.Value = Convert.ToInt32(color.GetHue());
                slider_saturation.Value = Convert.ToInt32(color.GetSaturation() * 100);
                slider_brightness.Value = Convert.ToInt32(color.GetBrightness() * 100);

                //set all labels
                lbl_red.Text = Convert.ToString(color.R);
                lbl_green.Text = Convert.ToString(color.G);
                lbl_blue.Text = Convert.ToString(color.B);

                lbl_hue.Text = Convert.ToString(color.GetHue());
                lbl_saturation.Text = Convert.ToString(color.GetSaturation());
                lbl_brightness.Text = Convert.ToString(color.GetBrightness());
            }
            else if (activeColorSpace == "HSB")
            {
                //precalc
                float Saturation = slider_saturation.Value * 0.01F;
                float Brightness = slider_brightness.Value * 0.01F;
                float Hue = slider_hue.Value;
                //get the color
                color = FromAhsb(255, Hue, Saturation, Brightness);
                //set other sliders
                slider_red.Value = color.R;
                slider_green.Value = color.G;
                slider_blue.Value = color.B;

                //set all labels
                lbl_red.Text = Convert.ToString(color.R);
                lbl_green.Text = Convert.ToString(color.G);
                lbl_blue.Text = Convert.ToString(color.B);

                lbl_hue.Text = Convert.ToString(color.GetHue());
                lbl_saturation.Text = Convert.ToString(color.GetSaturation());
                lbl_brightness.Text = Convert.ToString(color.GetBrightness());
            }
            picBox_Color.BackColor = color;
        }

        private void cSlider_Red_Scroll(object sender, EventArgs e)
        {
            colorCalc();
            activeColorSpace = "RGB";
        }

        private void slider_green_Scroll(object sender, EventArgs e)
        {
            colorCalc();
            activeColorSpace = "RGB";
        }

        private void slider_blue_Scroll(object sender, EventArgs e)
        {
            colorCalc();
            activeColorSpace = "RGB";
        }

        private void slider_hue_Scroll(object sender, EventArgs e)
        {
            colorCalc();
            activeColorSpace = "HSB";
        }

        private void slider_saturation_Scroll(object sender, EventArgs e)
        {
            colorCalc();
            activeColorSpace = "HSB";
        }

        private void slider_brightness_Scroll(object sender, EventArgs e)
        {
            colorCalc();
            activeColorSpace = "HSB";
        }











        // Hinweise / Ideen

        // 1. Screen V2 = Dominantesten farbendurchschnitt auf mehreren Entgegengesetzten farben 
        // z.b. 2 Farben -> 0-180 und 180 - 360 (>H< - SV)  }-> 
        // Jeweiliger_farbraum = 360 / Menge_an_Farben
        /*
         * 

        for(int i = 1; i < Menge_an_Farben; i++)
        {
            if(colorAt(x,y).Hue > Jeweiliger_farbraum * (i-1) && colorAt(x,y).Hue < Jeweiliger_farbraum * i)
        }


        Array als farbspeicher(aktuell) mit array.lenght zum auslesen der farben


        */
    }
}
