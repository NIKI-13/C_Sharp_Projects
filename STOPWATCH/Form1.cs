using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STOPWATCH
{
    public partial class Form1 : Form
    {
        int milSec, Sec, Min;
        bool isActive;
        private void btnStart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            isActive = false;
            ResetTime();
        }

        private void ResetTime()
        {
            milSec = 0;
            Sec = 0;
            Min = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isActive)
            {
                milSec++;

                if (milSec>=100)
                {
                    Sec++;
                    milSec = 0;

                    if (Sec>=60)
                    {
                        Min ++;
                        Sec = 0;
                    }
                }
            }

            DrawTime();
        }

        private void DrawTime()
        {
            miliSec.Text = String.Format("{0:00}",milSec);
            lblSec.Text = String.Format("{0:00}", Sec);
            lblMin.Text = String.Format("{0:00}", Min);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTime();

            isActive = false;
        }
    }
}
