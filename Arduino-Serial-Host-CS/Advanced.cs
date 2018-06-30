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
    public partial class Advanced : Form
    {


        public Advanced()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        static public System.Drawing.Color GetPixelColor(int x, int y)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, x, y);
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                         (int)(pixel & 0x0000FF00) >> 8,
                         (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }


        int fadeSpeed = 1000;
        byte fadeNumber = 1;
        bool buttonmode = false;
        Random rnd = new Random();



        Color AverageColorVal;



        bool PCEnabled = false;
        bool DESKEnabled = false;

        bool HSVoveride = false;

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




        private void button2_Click(object sender, EventArgs e)
        {
            if (Arduino_Port.IsOpen)
            {
                if (timer1.Enabled == true)
                {
                    disablingButton(btn_random);
                    timer1.Stop();
                }
                else
                {
                    enablingButton(btn_random);
                    timer1.Start();
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Arduino_Port.IsOpen == true)
            {

                int randomHue = rnd.Next(1, 360);

                Color randColor = FromAhsb(1, randomHue, 1, 0.5F);

                int red = randColor.R;
                int green = randColor.G;
                int blue = randColor.B;

                setColor(randColor);

            }
            else
            {

            }

        }

        private void btn_rgb_gradient_Click(object sender, EventArgs e)
        {

            if (timer_RGB_Gradient.Enabled == true)
            {
                timer_RGB_Gradient.Enabled = false;
                disablingButton(btn_rgb_gradient);
            }
            else
            {
                timer_RGB_Gradient.Enabled = true;
                enablingButton(btn_rgb_gradient);
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            fadeSpeed = Convert.ToInt32(numericUpDown1.Value);
        }

        private void timer_RGB_Gradient_Tick(object sender, EventArgs e)
        {
            timer_RGB_Gradient.Interval = fadeSpeed;
            if (Arduino_Port.IsOpen == true)
            {

                try
                {
                    switch (fadeNumber)
                    {
                        case 1:
                            setColor(Color.FromArgb(255, 0, 0));
                            Console.WriteLine("Red");
                            fadeNumber += 1;
                            break;
                        case 2:
                            setColor(Color.FromArgb(255, 0, 0));
                            Console.WriteLine("Yellow");
                            fadeNumber += 1;
                            break;
                        case 3:
                            setColor(Color.FromArgb(255, 0, 0));
                            Console.WriteLine("Green");
                            fadeNumber += 1;
                            break;
                        case 4:
                            setColor(Color.FromArgb(255, 0, 0));
                            Console.WriteLine("Cyan");
                            fadeNumber += 1;
                            break;
                        case 5:
                            setColor(Color.FromArgb(255, 0, 0));
                            Console.WriteLine("Blue");
                            fadeNumber += 1;
                            break;
                        case 6:
                            setColor(Color.FromArgb(255, 0, 0));
                            Console.WriteLine("Pink");
                            fadeNumber = 1;
                            break;
                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {

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

        private void timer_display_Tick(object sender, EventArgs e)
        {


            if (Arduino_Port.IsOpen)
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(getScreenColor));

                t.Start();

                picBox_1_1.BackColor = AverageColorVal;

                if (AverageColorVal.GetBrightness() < 0.6F)
                {
                    AverageColorVal = FromAhsb(AverageColorVal.A, AverageColorVal.GetHue(), 0.7F, AverageColorVal.GetBrightness() + 0.4F);
                }
                if (AverageColorVal.GetBrightness() > 1.0F)
                {
                    AverageColorVal = FromAhsb(AverageColorVal.A, AverageColorVal.GetHue(), 0.7F, AverageColorVal.GetBrightness() - 0.4F);
                }
                AverageColorVal = FromAhsb(AverageColorVal.A, AverageColorVal.GetHue(), 0.95F, AverageColorVal.GetBrightness());

                if (HSVoveride == true)
                {
                    double saturation = (Convert.ToDouble(trackBar_saturation.Value) / 1000);
                    double brightness = (Convert.ToDouble(trackBar_brightness.Value) / 1000);
                    AverageColorVal = FromAhsb(AverageColorVal.A, AverageColorVal.GetHue(), Convert.ToSingle(saturation), Convert.ToSingle(brightness));
                }

                //set picturepox after postprocessing
                picBox_1_2.BackColor = AverageColorVal;

                lbl_hue.Text = Convert.ToString(Convert.ToInt32(AverageColorVal.GetHue()));
                lbl_saturation.Text = Convert.ToString(AverageColorVal.GetSaturation());
                lbl_brightness.Text = Convert.ToString(AverageColorVal.GetBrightness());

                setColor(AverageColorVal);
            }

        }

        private void timer_display_V2_Tick(object sender, EventArgs e)
        {
            int howMuchAverages = 2;

            int jeweiliger_Farbraum = 360 / howMuchAverages;

            int Screen_X = Screen.PrimaryScreen.Bounds.Width;
            int Screen_Y = Screen.PrimaryScreen.Bounds.Height;




            Bitmap memoryImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Size s = new Size(memoryImage.Width, memoryImage.Height);

            Graphics memoryGraphics = Graphics.FromImage(memoryImage);

            memoryGraphics.CopyFromScreen(0, 0, 0, 0, s);


            LockBitmap ScreenBit = new LockBitmap(memoryImage);
            ScreenBit.LockBits();

            //new dynamic version
            int[,] AverageColorAll = new int[howMuchAverages, 3]; //AverageColor[i,R] [R=1;G=2;B=3]
            int[] usedPixel = new int[howMuchAverages]; //usedPixel[i]

            Console.WriteLine("Start analysing");
            for (int x = 0; x < Screen_X - 1; x++)
            {
                for (int y = 0; y < Screen_Y - 1; y++)
                {

                    // Color newColor = GetColorAt(location);
                    Color pixelColor = ScreenBit.GetPixel(x, y);
                    if (pixelColor.GetSaturation() > 0.6F && pixelColor.GetBrightness() > 0.25F && pixelColor.GetBrightness() < 0.65F)
                    {
                        for (int i = 1; i <= howMuchAverages; i++) //Ausnahme
                        {
                            if (pixelColor.GetHue() > jeweiliger_Farbraum * (i - 1) & pixelColor.GetHue() < jeweiliger_Farbraum * i)
                            {
                                //add 1 to the sum
                                usedPixel[i - 1]++;
                                //save color
                                AverageColorAll[i - 1, 0] += pixelColor.R;
                                AverageColorAll[i - 1, 1] += pixelColor.G;
                                AverageColorAll[i - 1, 2] += pixelColor.B;

                                //Console.WriteLine("At x=" + x + " and y=" + y + " Hue " + pixelColor.GetHue() + " Saturation " + pixelColor.GetSaturation() + " Brightness " + pixelColor.GetBrightness());
                            }
                        }
                    }
                }
            }


            Console.WriteLine("Completed analysing");


            Color[] AverageColorFinal = new Color[howMuchAverages]; //usedPixel[i]

            for (int i = 0; i < howMuchAverages; i++)
            {
                Console.WriteLine("usedPixel[" + i + "] = " + usedPixel[i]);
                AverageColorFinal[i] = Color.FromArgb(AverageColorAll[i, 0] / usedPixel[i], AverageColorAll[i, 1] / usedPixel[i], AverageColorAll[i, 2] / usedPixel[i]);
            }

            //before PicBox
            picBox_1_1.BackColor = AverageColorFinal[0];
            picBox_2_1.BackColor = AverageColorFinal[1];

            //post processing
            AverageColorFinal[0] = FromAhsb(255, AverageColorFinal[0].GetHue(), 0.8F, AverageColorFinal[0].GetBrightness());
            AverageColorFinal[1] = FromAhsb(255, AverageColorFinal[1].GetHue(), 0.8F, AverageColorFinal[1].GetBrightness());

            //after picBox
            picBox_1_2.BackColor = AverageColorFinal[0];
            picBox_2_2.BackColor = AverageColorFinal[1];


            //set color 1
            setColorWithTime(picBox_1_2.BackColor, 2000);
            //hold color 1
            setColorWithTime(picBox_1_2.BackColor, 1000);
            //set color 2
            setColorWithTime(picBox_2_2.BackColor, 2000);
            //hold color 2
            setColorWithTime(picBox_2_2.BackColor, 1000);
        }

        private void timer_display_V3_Tick(object sender, EventArgs e)
        {

        }

        private void getScreenColor()
        {

            int accurarity = 256;




            //get the "Screenshot"

            int ScreenMax_X = Screen.PrimaryScreen.Bounds.Width;
            int ScreenMax_Y = Screen.PrimaryScreen.Bounds.Height;

            Console.WriteLine("Width " + ScreenMax_X + " x " + ScreenMax_Y);



            int gridMax_X = ScreenMax_X;
            int gridMax_Y = ScreenMax_Y;

            Console.WriteLine("ScreenMax_X / accurarity  = " + gridMax_X + " ScreenMax_Y / accurarity = " + gridMax_Y);

            Color[,] grid = new Color[gridMax_X, gridMax_Y];

            Console.WriteLine("start getting Pixel");

            for (int Screen_X = 0; Screen_X <= (ScreenMax_X - accurarity); Screen_X += accurarity)
            {
                for (int Screen_Y = 0; Screen_Y <= (ScreenMax_Y - accurarity); Screen_Y += accurarity)
                {

                    Point location = new Point(Screen_X, Screen_Y);

                    Color newColor = GetColorAt(location);



                    grid[Screen_X, Screen_Y] = newColor;


                }
            }



            long sumAlpha = 0;
            long sumRed = 0;
            long sumGreen = 0;
            long sumBlue = 0;



            //calculate the average

            Console.WriteLine("start calculating the average");

            sumRed = 0;
            sumGreen = 0;
            sumBlue = 0;

            for (int x = 0; x <= (ScreenMax_X - accurarity); x += accurarity)
            {
                for (int y = 0; y <= (ScreenMax_Y - accurarity); y += accurarity)
                {

                    sumAlpha += Convert.ToInt64(grid[x, y].A);
                    sumRed += Convert.ToInt64(grid[x, y].R);
                    sumGreen += Convert.ToInt64(grid[x, y].G);
                    sumBlue += Convert.ToInt64(grid[x, y].B);



                }
            }

            Console.WriteLine("finished calculating the average");

            long pixelsMax = ((ScreenMax_X * ScreenMax_Y) / accurarity) / accurarity;

            sumAlpha = sumAlpha / Convert.ToInt64(pixelsMax);
            sumRed = sumRed / Convert.ToInt64(pixelsMax);
            sumGreen = sumGreen / Convert.ToInt64(pixelsMax);
            sumBlue = sumBlue / Convert.ToInt64(pixelsMax);

            AverageColorVal = System.Drawing.Color.FromArgb(Convert.ToInt32(sumAlpha), Convert.ToInt32(sumRed), Convert.ToInt32(sumGreen), Convert.ToInt32(sumBlue));




        }


        private void btn_AverageDisplayColor_Click(object sender, EventArgs e)
        {

            if (timer_display.Enabled == true)
            {
                disablingButton(btn_AverageDisplayColor);
                timer_display.Stop();
            }
            else
            {
                enablingButton(btn_AverageDisplayColor);
                timer_display.Start();
            }
        }

        private void btn_AverageDisplayColor_V2_Click(object sender, EventArgs e)
        {
            if (timer_display_V2.Enabled == true)
            {
                disablingButton(btn_AverageDisplayColor_V2);
                timer_display_V2.Stop();
            }
            else
            {
                enablingButton(btn_AverageDisplayColor_V2);
                timer_display_V2.Start();
            }
        }



        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        public Color GetColorAt(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }





            return screenPixel.GetPixel(0, 0);
        }

        private void button_enables_overide_Click(object sender, EventArgs e)
        {
            if (Arduino_Port.IsOpen)
            {
                if (HSVoveride == true)
                {
                    disablingButton(button_enables_overide);
                    HSVoveride = false;
                }
                else
                {
                    enablingButton(button_enables_overide);
                    HSVoveride = true;
                }
            }
        }


        public void setColor(Color color)
        {
            if (PCEnabled == true && DESKEnabled == false)
            {
                Arduino_Port.WriteLine("SET PC " + color.R + " " + color.G + " " + color.B + " " + color.R + " " + color.G + " " + color.B + " " + "1000" + " \n");
            }
            if (PCEnabled == false && DESKEnabled == true)
            {
                Arduino_Port.WriteLine("SET TABLE " + color.R + " " + color.G + " " + color.B + " " + color.R + " " + color.G + " " + color.B + " " + "1000" + " \n");
            }
            if (PCEnabled == true && DESKEnabled == true)
            {
                Arduino_Port.WriteLine("SET BOTH " + color.R + " " + color.G + " " + color.B + " " + color.R + " " + color.G + " " + color.B + " " + "1000" + " \n");
            }
        }
        public void setColorWithTime(Color color, int time)
        {
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

        public void btn_delay_up_Click(object sender, EventArgs e)
        {
            fadeSpeed += 100;
            lbl_delay.Text = Convert.ToString(fadeSpeed);
        }
        public void btn_delay_down_Click(object sender, EventArgs e)
        {
            if (fadeSpeed > 100)
            {
                fadeSpeed -= 100;
                lbl_delay.Text = Convert.ToString(fadeSpeed);
            }
            else
            {
                MessageBox.Show("You cannot lower the delay under 100ms");
            }
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
