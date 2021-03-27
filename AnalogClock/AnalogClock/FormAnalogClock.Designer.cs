
namespace AnalogClock
{
    partial class FormAnalogClock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxScaffold = new System.Windows.Forms.PictureBox();
            this.pictureBoxHourHand = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinuteHand = new System.Windows.Forms.PictureBox();
            this.pictureBoxSecondHand = new System.Windows.Forms.PictureBox();
            this.pictureBoxMilSecondHand = new System.Windows.Forms.PictureBox();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.labelCurrentDigitalDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScaffold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHourHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinuteHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecondHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMilSecondHand)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxScaffold
            // 
            this.pictureBoxScaffold.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxScaffold.Image = global::AnalogClock.Properties.Resources.scaffold;
            this.pictureBoxScaffold.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxScaffold.Name = "pictureBoxScaffold";
            this.pictureBoxScaffold.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxScaffold.TabIndex = 0;
            this.pictureBoxScaffold.TabStop = false;
            // 
            // pictureBoxHourHand
            // 
            this.pictureBoxHourHand.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHourHand.Image = global::AnalogClock.Properties.Resources.hour_hand;
            this.pictureBoxHourHand.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHourHand.Name = "pictureBoxHourHand";
            this.pictureBoxHourHand.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxHourHand.TabIndex = 1;
            this.pictureBoxHourHand.TabStop = false;
            // 
            // pictureBoxMinuteHand
            // 
            this.pictureBoxMinuteHand.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMinuteHand.Image = global::AnalogClock.Properties.Resources.minute_hand;
            this.pictureBoxMinuteHand.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMinuteHand.Name = "pictureBoxMinuteHand";
            this.pictureBoxMinuteHand.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxMinuteHand.TabIndex = 2;
            this.pictureBoxMinuteHand.TabStop = false;
            // 
            // pictureBoxSecondHand
            // 
            this.pictureBoxSecondHand.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSecondHand.Image = global::AnalogClock.Properties.Resources.second_hand;
            this.pictureBoxSecondHand.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSecondHand.Name = "pictureBoxSecondHand";
            this.pictureBoxSecondHand.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxSecondHand.TabIndex = 3;
            this.pictureBoxSecondHand.TabStop = false;
            // 
            // pictureBoxMilSecondHand
            // 
            this.pictureBoxMilSecondHand.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMilSecondHand.Image = global::AnalogClock.Properties.Resources.milsecond_hand;
            this.pictureBoxMilSecondHand.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMilSecondHand.Name = "pictureBoxMilSecondHand";
            this.pictureBoxMilSecondHand.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxMilSecondHand.TabIndex = 4;
            this.pictureBoxMilSecondHand.TabStop = false;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // labelCurrentDigitalDate
            // 
            this.labelCurrentDigitalDate.AutoSize = true;
            this.labelCurrentDigitalDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentDigitalDate.Location = new System.Drawing.Point(183, 368);
            this.labelCurrentDigitalDate.Name = "labelCurrentDigitalDate";
            this.labelCurrentDigitalDate.Size = new System.Drawing.Size(139, 30);
            this.labelCurrentDigitalDate.TabIndex = 5;
            this.labelCurrentDigitalDate.Text = "00:00:00:000";
            // 
            // FormAnalogClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 500);
            this.Controls.Add(this.labelCurrentDigitalDate);
            this.Controls.Add(this.pictureBoxMilSecondHand);
            this.Controls.Add(this.pictureBoxSecondHand);
            this.Controls.Add(this.pictureBoxMinuteHand);
            this.Controls.Add(this.pictureBoxHourHand);
            this.Controls.Add(this.pictureBoxScaffold);
            this.Name = "FormAnalogClock";
            this.Text = "FormAnalogClock";
            this.Load += new System.EventHandler(this.FormAnalogClock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScaffold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHourHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinuteHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecondHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMilSecondHand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxScaffold;
        private System.Windows.Forms.PictureBox pictureBoxHourHand;
        private System.Windows.Forms.PictureBox pictureBoxMinuteHand;
        private System.Windows.Forms.PictureBox pictureBoxSecondHand;
        private System.Windows.Forms.PictureBox pictureBoxMilSecondHand;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label labelCurrentDigitalDate;
    }
}