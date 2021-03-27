using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExamplesAboutTimer
{
    public partial class Form2 : Form
    {
        Stopwatch stopWatch = new Stopwatch();
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!stopWatch.IsRunning)
            {
                stopWatch.Start();
            }
        }

        private void buttonWait_Click(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                stopWatch.Stop();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            labelStopwatch.Text = "00:00:00:00:000";
            stopWatch.Reset();
        }

        private void timerStopwatch_Tick(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                TimeSpan timeSpan = stopWatch.Elapsed;
                labelStopwatch.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}:{4:000}",
                    timeSpan.Days,
                    timeSpan.Hours, 
                    timeSpan.Minutes, 
                    timeSpan.Seconds, 
                    timeSpan.Milliseconds);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            listBoxRecords.Items.Add((listBoxRecords.Items.Count+1) + " : " + labelStopwatch.Text);
        }
    }
}
