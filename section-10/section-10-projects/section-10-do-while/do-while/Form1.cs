using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			int loopWorkAmount = 0, loopControlValue = 10;
			while (loopControlValue<20)
			{
				textBox1.Text += loopWorkAmount.ToString() + Environment.NewLine;
				loopControlValue++;
				loopWorkAmount++;
			}
			MessageBox.Show(loopWorkAmount.ToString());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			int loopWorkAmount = 0, loopControlValue = 10;
			do
			{
				loopControlValue++;
				loopWorkAmount++;
				textBox1.Text += loopWorkAmount.ToString() + Environment.NewLine;

			} while (loopControlValue < 20);
				MessageBox.Show(loopWorkAmount.ToString());


		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			int inLoopWorkAmount = 0, inLoopControlValue = 0;
			int outLoopControlValue=10, outLoopWorkAmount = 0;
			while(outLoopControlValue<20)
			{
				inLoopControlValue = 0;
				while(inLoopControlValue < 8)
				{
					inLoopControlValue++;
					inLoopWorkAmount++;
					textBox1.Text += outLoopControlValue.ToString() + " " + inLoopControlValue.ToString() +
						Environment.NewLine;
				}
				outLoopControlValue++;
				outLoopWorkAmount++;

			}
			MessageBox.Show("outloopwork amount works " + outLoopWorkAmount.ToString() + 
				" times.  In loop work amount worked " + inLoopWorkAmount.ToString());
		}
	}
}
