
namespace ExamplesAboutTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelCurrentYear = new System.Windows.Forms.Label();
            this.labelCurrentMonth = new System.Windows.Forms.Label();
            this.labelCurrentDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentTime.Location = new System.Drawing.Point(12, 9);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(229, 89);
            this.labelCurrentTime.TabIndex = 0;
            this.labelCurrentTime.Text = "label1";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelCurrentYear
            // 
            this.labelCurrentYear.AutoSize = true;
            this.labelCurrentYear.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentYear.Location = new System.Drawing.Point(12, 102);
            this.labelCurrentYear.Name = "labelCurrentYear";
            this.labelCurrentYear.Size = new System.Drawing.Size(229, 89);
            this.labelCurrentYear.TabIndex = 1;
            this.labelCurrentYear.Text = "label1";
            // 
            // labelCurrentMonth
            // 
            this.labelCurrentMonth.AutoSize = true;
            this.labelCurrentMonth.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentMonth.Location = new System.Drawing.Point(13, 195);
            this.labelCurrentMonth.Name = "labelCurrentMonth";
            this.labelCurrentMonth.Size = new System.Drawing.Size(229, 89);
            this.labelCurrentMonth.TabIndex = 2;
            this.labelCurrentMonth.Text = "label1";
            // 
            // labelCurrentDay
            // 
            this.labelCurrentDay.AutoSize = true;
            this.labelCurrentDay.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentDay.Location = new System.Drawing.Point(13, 288);
            this.labelCurrentDay.Name = "labelCurrentDay";
            this.labelCurrentDay.Size = new System.Drawing.Size(229, 89);
            this.labelCurrentDay.TabIndex = 3;
            this.labelCurrentDay.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCurrentDay);
            this.Controls.Add(this.labelCurrentMonth);
            this.Controls.Add(this.labelCurrentYear);
            this.Controls.Add(this.labelCurrentTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelCurrentYear;
        private System.Windows.Forms.Label labelCurrentMonth;
        private System.Windows.Forms.Label labelCurrentDay;
    }
}

