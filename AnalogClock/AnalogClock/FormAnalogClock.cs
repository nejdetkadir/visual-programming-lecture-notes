using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class FormAnalogClock : Form
    {
        Bitmap hourHandImage = new Bitmap(AnalogClock.Properties.Resources.hour_hand);
        Bitmap minuteHandImage = new Bitmap(AnalogClock.Properties.Resources.minute_hand);
        Bitmap secondHandImage = new Bitmap(AnalogClock.Properties.Resources.second_hand);
        Bitmap milSecondHandImage = new Bitmap(AnalogClock.Properties.Resources.milsecond_hand);
        int hour, minute, second, milsecond;
        DateTime dateTime;

        public FormAnalogClock()
        {
            InitializeComponent();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            hour = dateTime.Hour;
            minute = dateTime.Minute;
            second = dateTime.Second;
            milsecond = dateTime.Millisecond;

            Single milsecondAngle = milsecond * (float)(360) / (float)(1000);
            Single secondAngle = second * 6 + milsecond / 1000;
            Single minuteAngle = minute * 6 + second / 60;
            Single hourAngle = hour * 30 + minute / 12;

            pictureBoxMilSecondHand.Image = rotateThePicture(milSecondHandImage, milsecondAngle);
            pictureBoxSecondHand.Image = rotateThePicture(secondHandImage, secondAngle);
            pictureBoxMinuteHand.Image = rotateThePicture(minuteHandImage, minuteAngle);
            pictureBoxHourHand.Image = rotateThePicture(hourHandImage, hourAngle);

            labelCurrentDigitalDate.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:000}",
                hour, minute, second, milsecond);
        }

        private Bitmap rotateThePicture(Bitmap oldPicture, float angle)
        {
            Bitmap newPicture = new Bitmap(oldPicture.Width, oldPicture.Height);
            using (Graphics graphics = Graphics.FromImage(newPicture))
            {
                graphics.TranslateTransform(oldPicture.Width / 2, oldPicture.Height / 2);
                graphics.RotateTransform(angle);
                graphics.TranslateTransform(-oldPicture.Width / 2, -oldPicture.Height / 2);
                graphics.DrawImage(oldPicture, new Point(0, 0));
                return newPicture;
            }
        }

        private void FormAnalogClock_Load(object sender, EventArgs e)
        {
            pictureBoxHourHand.Parent = pictureBoxScaffold;
            pictureBoxMinuteHand.Parent = pictureBoxHourHand;
            pictureBoxSecondHand.Parent = pictureBoxMinuteHand;
            pictureBoxMilSecondHand.Parent = pictureBoxSecondHand;
            labelCurrentDigitalDate.Parent = pictureBoxMilSecondHand;
        }
    }
}
