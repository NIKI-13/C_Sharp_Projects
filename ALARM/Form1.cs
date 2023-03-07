using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;    //U NEED THIS FOR THE SoundPlayer
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALARM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblStatus.Text = "Active";
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Stopped";
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            player.Stop();

        }

        SoundPlayer player = new SoundPlayer();
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime=DateTime.Now;
            DateTime alarmTime = dateTimePicker1.Value;

            if(currentTime.Hour==alarmTime.Hour && currentTime.Minute== 
                alarmTime.Minute && currentTime.Second==alarmTime.Second)
            {
                timer1.Stop();

                player.SoundLocation = (@"C:\Users\NIKI\Downloads\warning-alarm.wav");
                    player.PlayLooping();
            }
        }

        
    }
}
