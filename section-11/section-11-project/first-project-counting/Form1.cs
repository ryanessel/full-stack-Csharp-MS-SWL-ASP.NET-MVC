using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_project_counting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void btnExit_Click(object sender, EventArgs e)
		{
			//works like the x button on a window; exits the window
			Application.Exit();

		}


		int firstNumber = 0, lastNumber = 0;
		int divisibleTerm = 1;

		private void Form1_Load(object sender, EventArgs e)
		{
			cmbDivisibleTerm.Items.Add("2");
			cmbDivisibleTerm.Items.Add("3");
			cmbDivisibleTerm.Items.Add("4");
			cmbDivisibleTerm.Items.Add("5");
			cmbDivisibleTerm.Items.Add("6");
			cmbDivisibleTerm.Items.Add("7");
			cmbDivisibleTerm.Items.Add("8");
			cmbDivisibleTerm.Items.Add("10");
		}

		private void cmbDivisibleTerm_SelectedIndexChanged(object sender, EventArgs e)
		{
			divisibleTerm = Convert.ToInt32(cmbDivisibleTerm.SelectedItem);

		}
		string divisibleNumber = "";
		private void btnCount_Click(object sender, EventArgs e)
		{
			firstNumber = Convert.ToInt32(txtStartFrom.Text);
			lastNumber = Convert.ToInt32(txtTo.Text);
			MessageBox.Show("Divisible "+ divisibleTerm + " From " + firstNumber + " To " + lastNumber);
			for (int i = firstNumber; i < lastNumber; i++)
			{
				if (i % divisibleTerm == 0)
				{
					divisibleNumber += i.ToString() + " ";
				}
				txtDivisibleNumbers.Text = divisibleNumber;
			}
		}
	}
}
