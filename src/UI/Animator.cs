//----------------------------------------------------------------------
// Name: Brian Rodenkirch
// Project: Generic RPG 2, a simple turn-based RPG
// Purpose: This is a general class made to be used for animating WinForms controls, such as the map when it scrolls.
//----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GenericRPG2.UI
{
    //-------------------------------------------------------------------
    // This class handles the movement of WinForms controls.
    //-------------------------------------------------------------------
    public abstract class Animator
    {
        //----------------------------------------------------------------
        // This method moves a WinForms control by the desired amount over the desired period of time.
        //----------------------------------------------------------------
        public static void move(Control control, int xChange, int yChange, double time)
        {
            int startXPos = control.Left;
            int startYPos = control.Top;

            long tpm = TimeSpan.TicksPerMillisecond;

            long microseconds = System.DateTime.Now.Ticks * 1000 / tpm;

            double frameRate = 59.94;

            int totalFrames = (int)(time * frameRate);

            double xStep = (double)xChange / totalFrames;
            double yStep = (double)yChange / totalFrames;

            for (int frame = 1; frame <= totalFrames; frame++)
            {
                while (System.DateTime.Now.Ticks * 1000 / tpm < microseconds + frame * 1000000 / frameRate) { }

                control.Left = startXPos + (int)Math.Round(frame * xStep);
                control.Top = startYPos + (int)Math.Round(frame * yStep);

                control.Refresh();

            }

        }

        public static void moveAnimated(PictureBox pictureBox, int xChange, int yChange, double time, List<Image> imageList)
        {
            int startXPos = pictureBox.Left;
            int startYPos = pictureBox.Top;

            long tpm = TimeSpan.TicksPerMillisecond;

            long microseconds = System.DateTime.Now.Ticks * 1000 / tpm;

            double frameRate = 59.94;

            int totalFrames = (int)(time * frameRate);

            double xStep = (double)xChange / totalFrames;
            double yStep = (double)yChange / totalFrames;

            for (int frame = 1; frame <= totalFrames; frame++)
            {
                while (System.DateTime.Now.Ticks * 1000 / tpm < microseconds + frame * 1000000 / frameRate) { }

                pictureBox.Left = startXPos + (int)Math.Round(frame * xStep);
                pictureBox.Top = startYPos + (int)Math.Round(frame * yStep);

                pictureBox.Image = imageList[frame % imageList.Count];

                pictureBox.Refresh();

            }

        }

        public static void animateHealthBar(ProgressBar healthBar, double time, int newValue)
        {
            long tpm = TimeSpan.TicksPerMillisecond;
            long microseconds = System.DateTime.Now.Ticks * 1000 / tpm;
            double frameRate = 59.94;
            int totalFrames = (int)(time * frameRate);

            int currentValue = healthBar.Value;
            int maxValue = healthBar.Maximum;
            int valueChange = newValue - currentValue;

            double valueStep = (double)valueChange / totalFrames;
            
            for (int frame = 1; frame <= totalFrames; frame++)
            {
                while (System.DateTime.Now.Ticks * 1000 / tpm < microseconds + frame * 1000000 / frameRate) { }

                healthBar.Value = currentValue + (int)Math.Round(frame * valueStep);
                healthBar.ForeColor = Color.FromArgb(255, (int)(-Math.Abs(255 * (currentValue + frame * valueStep) / maxValue - 127.5) - 255 * (currentValue + frame * valueStep) / maxValue + 382.5), (int)(-Math.Abs(-255 * (currentValue + frame * valueStep) / maxValue + 127.5) + 255 * (currentValue + frame * valueStep) / maxValue + 127.5), 0);
                
                healthBar.Refresh();

            }

        }

    }

}
