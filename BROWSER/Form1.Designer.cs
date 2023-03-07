namespace BROWSER
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
            this.btnBack = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 38);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox.Location = new System.Drawing.Point(292, 24);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(662, 34);
            this.textBox.TabIndex = 1;
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(93, 22);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(74, 38);
            this.btnForward.TabIndex = 2;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(960, 22);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(76, 38);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(3, 66);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1033, 485);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 553);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

