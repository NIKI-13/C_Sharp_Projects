namespace STOPWATCH
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
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.miliSec = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Bold);
            this.lblMin.ForeColor = System.Drawing.Color.Lime;
            this.lblMin.Location = new System.Drawing.Point(164, 76);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(149, 101);
            this.lblMin.TabIndex = 0;
            this.lblMin.Text = "00";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.BackColor = System.Drawing.Color.Transparent;
            this.lblSec.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Bold);
            this.lblSec.ForeColor = System.Drawing.Color.Lime;
            this.lblSec.Location = new System.Drawing.Point(361, 76);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(149, 101);
            this.lblSec.TabIndex = 1;
            this.lblSec.Text = "00";
            // 
            // miliSec
            // 
            this.miliSec.AutoSize = true;
            this.miliSec.BackColor = System.Drawing.Color.Transparent;
            this.miliSec.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.miliSec.ForeColor = System.Drawing.Color.Lime;
            this.miliSec.Location = new System.Drawing.Point(574, 109);
            this.miliSec.Name = "miliSec";
            this.miliSec.Size = new System.Drawing.Size(89, 60);
            this.miliSec.TabIndex = 2;
            this.miliSec.Text = "00";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(155, 305);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 58);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Location = new System.Drawing.Point(337, 305);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(145, 58);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MediumBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Location = new System.Drawing.Point(518, 305);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(145, 58);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(492, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 81);
            this.label1.TabIndex = 6;
            this.label1.Text = " .";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 40.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(288, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 82);
            this.label2.TabIndex = 7;
            this.label2.Text = " :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STOPWATCH.Properties.Resources.fast_internet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.miliSec);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Stopwatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label miliSec;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

