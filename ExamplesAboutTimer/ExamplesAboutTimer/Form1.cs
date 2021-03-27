using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamplesAboutTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            labelCurrentTime.Text = currentTime.ToString();
            labelCurrentYear.Text = currentTime.Year.ToString();
            labelCurrentMonth.Text = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.MonthNames[currentTime.Month - 1];
            labelCurrentDay.Text = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int) currentTime.DayOfWeek];
        }
    }
}
