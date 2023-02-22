using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void btn1Params_Click(object sender, EventArgs e)
		{
			Teacher teacher1= new Teacher();
			teacher1.SetVals(23);
			string msgTxt = teacher1.GetVals();
			textBox1.Text = msgTxt;
		}

		private void btn2Params_Click(object sender, EventArgs e)
		{
			Teacher teacher1 = new Teacher();
			teacher1.SetVals(23, "peter");
			string msgTxt = teacher1.GetVals();
			textBox1.Text = msgTxt;
		}

		private void btn3Params_Click(object sender, EventArgs e)
		{
			Teacher teacher1 = new Teacher();
			teacher1.SetVals(23, "peter", 40000);
			string msgTxt = teacher1.GetVals();
			textBox1.Text = msgTxt;
		}

		private void btn4Params_Click(object sender, EventArgs e)
		{
			Teacher teacher1 = new Teacher();
			teacher1.SetVals(23, "peter", 40000, "Gym Teacher");
			string msgTxt = teacher1.GetVals();
			textBox1.Text = msgTxt;
		}

		private void btnVirtual_Click(object sender, EventArgs e)
		{
			Employee2 emp1 = new Employee2();
			string msgTxt = emp1.SetVals(23, "peter", 40000);
			textBox1.Text = msgTxt;
		}

		private void btnOverride_Click(object sender, EventArgs e)
		{
			Teacher2 teach1 = new Teacher2();
			string msgTxt = teach1.SetVals(23, "peter", 40000);
			textBox1.Text = msgTxt;
		}
	}
}
