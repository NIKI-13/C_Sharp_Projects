using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONNECT_FORMS
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public TextBox tb1, tb2;

        public Form1()
        {
            InitializeComponent();
            instance = this;
            tb1 = textBox1;
            tb2 = textBox2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.instance.lab1.Text = tb1.Text;
            Form2.instance.lab2.Text = tb2.Text;
        }
    }
}
