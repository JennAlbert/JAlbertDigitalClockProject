namespace JAlbertDigitalClock
{
    partial class DigitalClock
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
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.clockLabel = new System.Windows.Forms.Label();
            this.timerStart = new System.Windows.Forms.Button();
            this.timerStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.BackColor = System.Drawing.Color.Black;
            this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F);
            this.clockLabel.Location = new System.Drawing.Point(132, 125);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(654, 170);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "00:00:00";
            // 
            // timerStart
            // 
            this.timerStart.Location = new System.Drawing.Point(235, 341);
            this.timerStart.Name = "timerStart";
            this.timerStart.Size = new System.Drawing.Size(122, 42);
            this.timerStart.TabIndex = 1;
            this.timerStart.Text = "Start";
            this.timerStart.UseVisualStyleBackColor = true;
            this.timerStart.Click += new System.EventHandler(this.timerStart_Click);
            // 
            // timerStop
            // 
            this.timerStop.Location = new System.Drawing.Point(598, 341);
            this.timerStop.Name = "timerStop";
            this.timerStop.Size = new System.Drawing.Size(126, 42);
            this.timerStop.TabIndex = 2;
            this.timerStop.Text = "Stop";
            this.timerStop.UseVisualStyleBackColor = true;
            this.timerStop.Click += new System.EventHandler(this.timerStop_Click);
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.timerStop);
            this.Controls.Add(this.timerStart);
            this.Controls.Add(this.clockLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DigitalClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.DigitalClock_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Button timerStart;
        private System.Windows.Forms.Button timerStop;
    }
}

