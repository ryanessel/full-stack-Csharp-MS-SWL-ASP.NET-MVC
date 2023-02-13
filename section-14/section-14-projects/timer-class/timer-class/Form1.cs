using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void btnStart_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}

		//Tick event - create by double cliciing the timer obj or by clicking lighting bolt in properties then double clikign the blank box
		int counter = 60;
		private void timer1_Tick(object sender, EventArgs e)
		{
				lblTimerReadOut.Text = counter.ToString();
				progressBar1.Value = counter;
				counter--;
			if (counter < 0)
			{
				timer1.Stop();
				MessageBox.Show("Timer Stopped/Load Complete", "Status");
				counter = 60;
				return;
			}
			if(counter  % 2 == 1) btnMsgFlash.BackColor= Color.Red;
			else btnMsgFlash.BackColor= Color.White;
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lblTimerReadOut.Text = counter.ToString();
		}
	}
}
