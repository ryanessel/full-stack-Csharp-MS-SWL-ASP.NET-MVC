using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			string ivalue = "";
			for (int i = 0; i < 30; i++) 
			{
				ivalue += " " +  i + " ";
			}
			MessageBox.Show(ivalue);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string ivalue = "";
			for (int i = 0; i < 10; i++)
			{

				for (int k = 0; k < 10; k++)
				{
					ivalue += "i: " + i + " k: " + k + Environment.NewLine;// evnvironment new line gives us a new line for each loop val
				}

				richTextBox1.Text = ivalue;


			}

		}
	}
}
