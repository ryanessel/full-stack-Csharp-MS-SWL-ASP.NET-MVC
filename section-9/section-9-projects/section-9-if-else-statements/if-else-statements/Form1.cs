using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_statements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			int a = 20, b = 30;
			string name = "Charles";
			bool control = true;

			if(a == 20)
			{
				label1.Text = " 'if' block 1 was executed";
			}
			if(!control)
			{
				textBox1.Text = " 'if' block 2 was executed"; 
			}
			if(a<=b)
			{
				MessageBox.Show("'if' block3 was executed");
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{

			int a = 20, b = 30;
			string name = "Charles";
			bool control = true;

			if (a == 30)
				label1.Text = " 'if' block 1 was executed";

			else if (control)
				textBox1.Text = " 'if' block 2 was executed";

			else if (a >= b)
				MessageBox.Show("'if' block3 was executed");

			else
				textBox1.Text = "'if' block4 was executed";

		}

		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("do you want to abort?", "if control", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes) 
			{
				textBox1.Text = "YES was chosen";
			}

			else if (result == DialogResult.No) 
			{
				textBox1.Text = "NO was chosen";
			}
			else
			{
				textBox1.Text = "Cancel was chosen";
			}


		}

		private void button4_Click(object sender, EventArgs e)
		{
			int a = 10, b = 20;
			string ternaryresult;
			ternaryresult = a < b ? b.ToString() : a.ToString();
			MessageBox.Show(ternaryresult, "Ternary Result is ... ");
		}
	}
}
