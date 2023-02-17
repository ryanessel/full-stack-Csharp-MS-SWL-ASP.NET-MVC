using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void btnSend_Click(object sender, EventArgs e)
		{
			Employee employeeDetails = new Employee();
			employeeDetails.EmployeeName = txtName.Text;
			employeeDetails.EmployeeAge = Convert.ToInt32(txtAge.Text);
			employeeDetails.EmployeePosition = txtPosition.Text;

			//sending the stuff above to another form
			FrmEmployeeDetails frm = new FrmEmployeeDetails();
			frm.lblAge.Text = employeeDetails.EmployeeAge.ToString();
			frm.lblName.Text = employeeDetails.EmployeeName;
			frm.lblPosition.Text = employeeDetails.EmployeePosition;
			frm.ShowDialog();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
