
namespace AnalogClock
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
            this.pictureBoxClock = new System.Windows.Forms.PictureBox();
            this.buttonTurn = new System.Windows.Forms.Button();
            this.pictureBoxHourHand = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHourHand)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxClock
            // 
            this.pictureBoxClock.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxClock.Image = global::AnalogClock.Properties.Resources.scaffold;
            this.pictureBoxClock.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxClock.Name = "pictureBoxClock";
            this.pictureBoxClock.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxClock.TabIndex = 0;
            this.pictureBoxClock.TabStop = false;
            // 
            // buttonTurn
            // 
            this.buttonTurn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTurn.Location = new System.Drawing.Point(527, 40);
            this.buttonTurn.Name = "buttonTurn";
            this.buttonTurn.Size = new System.Drawing.Size(112, 49);
            this.buttonTurn.TabIndex = 1;
            this.buttonTurn.Text = "TURN";
            this.buttonTurn.UseVisualStyleBackColor = true;
            this.buttonTurn.Click += new System.EventHandler(this.buttonTurn_Click);
            // 
            // pictureBoxHourHand
            // 
            this.pictureBoxHourHand.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHourHand.Image = global::AnalogClock.Properties.Resources.hour_hand;
            this.pictureBoxHourHand.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHourHand.Name = "pictureBoxHourHand";
            this.pictureBoxHourHand.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxHourHand.TabIndex = 2;
            this.pictureBoxHourHand.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 507);
            this.Controls.Add(this.pictureBoxHourHand);
            this.Controls.Add(this.buttonTurn);
            this.Controls.Add(this.pictureBoxClock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHourHand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClock;
        private System.Windows.Forms.Button buttonTurn;
        private System.Windows.Forms.PictureBox pictureBoxHourHand;
    }
}

