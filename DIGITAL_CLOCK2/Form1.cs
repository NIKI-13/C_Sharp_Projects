using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIGITAL_CLOCK2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSec.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM d yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");

            //THIS IS FOR THE LOCATION OF THE SECONDS

            lblSec.Location= new Point(lblTime.Location.X + lblTime.Width -5,
                lblSec.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
