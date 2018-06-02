﻿using System;
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
        byte fadeNumber = 1;
        bool buttonmode = false;
        Random rnd = new Random();



       
        bool PCEnabled = false;
        bool DESKEnabled = false;

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




       
       


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            fadeSpeed = Convert.ToInt32(numericUpDown1.Value);
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
            timer_colorRefresh.Interval = fadeSpeed;

            Color newColor = Color.FromArgb(cSlider_Red.Value, cSlider_Green.Value, cSlider_Blue.Value);

            setColorWithTime(newColor, fadeSpeed);
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
