namespace ALARM
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(77, 197);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 83);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(339, 197);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(141, 83);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Orange;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.LightSkyBlue;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 43);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(85, 379);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(98, 38);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ALARM.Properties.Resources.JANE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(656, 448);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Segoe UI", 9.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer1;
    }
}

