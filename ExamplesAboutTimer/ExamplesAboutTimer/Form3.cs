using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExamplesAboutTimer
{
    public partial class Form3 : Form
    {
        int hour = 0, minute = 0, second = 0;

        private void timerAlarm_Tick(object sender, EventArgs e)
        {
            if (second == 0 && minute == 0)
            {
                if (hour > 0)
                {
                    hour--;
                    minute = 59;
                    second = 59;
                }
            }
            
            if (second == 0)
            {
                if (minute > 0)
                {
                    minute--;
                    second = 59;
                }
            }

            updateLabelTime();

            if (hour == 0 && minute == 0 && second == 0)
            {
                timerAlarm.Stop();
                MessageBox.Show("DING DANG DONG!");
            } else
            {
                second--;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerAlarm.Stop();
            hour = 0;
            minute = 0;
            second = 0;
            updateLabelTime();
        }

        private void updateLabelTime()
        {
            labelTime.Text = string.Format("{0:00}:{1:00}:{2:00}",
                hour,
                minute,
                second);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            hour = (int)numericUpDownHour.Value;
            minute = (int)numericUpDownMinute.Value;
            second = (int)numericUpDownSecond.Value;
            timerAlarm.Start();
        }

        public Form3()
        {
            InitializeComponent();
        }
    }
}
