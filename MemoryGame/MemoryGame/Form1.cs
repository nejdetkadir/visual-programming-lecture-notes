using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>() { "l", "l", "o", "o", "r", "r", "e", "e", "m", "m", "i", "i", "p", "p", "s", "s" };
        Label firstClickedLabel = null;
        Label secondClickedLabel = null;

        private void SetIcons()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label label = control as Label;
                if (label != null)
                {
                    int randomIndex = random.Next(icons.Count);
                    label.Text = icons[randomIndex];
                    label.ForeColor = label.BackColor;
                    icons.RemoveAt(randomIndex);
                }
            }
        }
        
        public Form1()
        {
            InitializeComponent();
            SetIcons();
        }

        private void labelClicked(object sender, EventArgs e)
        {   
            if (!timer1.Enabled)
            {
                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {
                    if (clickedLabel.ForeColor != Color.Black)
                    {
                        if (firstClickedLabel == null)
                        {
                            firstClickedLabel = clickedLabel;
                            firstClickedLabel.ForeColor = Color.Black;
                        }
                        else
                        {
                            secondClickedLabel = clickedLabel;
                            secondClickedLabel.ForeColor = Color.Black;

                            if (firstClickedLabel.Text == secondClickedLabel.Text)
                            {
                                firstClickedLabel = null;
                                secondClickedLabel = null;

                                if (IsFinished())
                                {
                                    MessageBox.Show("Game Over! You won :)");
                                    Close();
                                }
                            } else
                            {
                                timer1.Start();
                            }
                        }
                    }
                }
            } 
        }

        private Boolean IsFinished()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label label = control as Label;
                if (label != null)
                {
                    if (label.ForeColor == label.BackColor)
                    {
                        return false;
                    }
                }
                
            }
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (firstClickedLabel != null && secondClickedLabel != null)
            {
                firstClickedLabel.ForeColor = firstClickedLabel.BackColor;
                secondClickedLabel.ForeColor = secondClickedLabel.BackColor;
                firstClickedLabel = null;
                secondClickedLabel = null;
            }
        }
    }
}
