using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class Form1 : Form
    {
        Bitmap hourHandImage;
        int angle = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxHourHand.Parent = pictureBoxClock;
            hourHandImage = new Bitmap(AnalogClock.Properties.Resources.hour_hand);

        }

        private void buttonTurn_Click(object sender, EventArgs e)
        {
            angle = angle == 360 ? 0 : angle + 6;
            pictureBoxHourHand.Image = rotateThePicture(hourHandImage, angle);
            
            if (angle == 360)
            {
                angle = 0;
            }
        }

        private Bitmap rotateThePicture(Bitmap oldPicture, float angle)
        {
            Bitmap newPicture = new Bitmap(oldPicture.Width, oldPicture.Height);
            using (Graphics graphics = Graphics.FromImage(newPicture))
            {
                graphics.TranslateTransform(oldPicture.Width / 2, oldPicture.Height/2);
                graphics.RotateTransform(angle);
                graphics.TranslateTransform(-oldPicture.Width / 2, -oldPicture.Height / 2);
                graphics.DrawImage(oldPicture, new Point(0, 0));
                return newPicture;
            }
        }
    }
}
