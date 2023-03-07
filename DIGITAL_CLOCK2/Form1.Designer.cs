namespace DIGITAL_CLOCK2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Name = "lblTime";
            // 
            // lblSec
            // 
            resources.ApplyResources(this.lblSec, "lblSec");
            this.lblSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSec.ForeColor = System.Drawing.Color.White;
            this.lblSec.Name = "lblSec";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Name = "lblDate";
            // 
            // lblDay
            // 
            resources.ApplyResources(this.lblDay, "lblDay");
            this.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Name = "lblDay";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblTime);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Timer timer;
    }
}

