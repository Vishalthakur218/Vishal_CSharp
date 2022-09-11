using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watch
{
    public partial class Form1 : Form
    {
        int progress = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        int sec = 0;
        int min = 0;
        int hr = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec > 59)
            {
                min++;
                sec = 0;
            }
            if (min > 59)
            {
                hr++;
                min = 0;
            }
            label1.Text = hr.ToString() + ":" + min.ToString() + ":" + sec.ToString();

            // inc pb
            progress += 1;
            if (progress >= 100)
            {
                timer1.Enabled = false;
                timer1.Stop();
            }
            progressBar1.Value = progress;

        }

        private void START_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
           // timer1.Interval = 50;
        }

        private void STOP_Click(object sender, EventArgs e)
        {
            timer1.Stop();
           

        }

        private void RESET_Click(object sender, EventArgs e)
        {   
            min=0;
            sec=0;
            hr=0;
            label1.Text = hr.ToString() + ":" + min.ToString() + ":" + sec.ToString();
            timer1.Stop();
            progress = 0;
            progressBar1.Value = 0;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
