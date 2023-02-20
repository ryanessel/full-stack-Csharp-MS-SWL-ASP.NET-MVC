using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ineritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			Teacher teacher1 = new Teacher();
			teacher1.Setvalues();
			teacher1.SetValues2();
			teacher1.FindSalary();
			string allValues = "";
			allValues += "First Name: " + teacher1.FirstName + Environment.NewLine;
			allValues += "Gender: " + teacher1.Gender + Environment.NewLine;
			allValues += "Age: " + teacher1.Age + Environment.NewLine;
			allValues += "Branch: " + teacher1.Branch + Environment.NewLine;
			allValues += "Salary: " + teacher1.Salary + Environment.NewLine;
			textBox1.Text = allValues;

		}
	}
}
