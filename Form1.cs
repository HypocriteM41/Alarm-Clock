using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string music;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                music = open.FileName;
                textBox1.Text = open.SafeFileName;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            timer2.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = maskedTextBox1.Text;
            maskedTextBox1.Text = "";
            timer2.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Text == label2.Text)
            {
                axWindowsMediaPlayer1.URL = music;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
