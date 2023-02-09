using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classes_and_objects
{
     partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee personelDetail = new Employee();
        private void btnSetValues_Click(object sender, EventArgs e)
        {
            
            personelDetail.EmployeeID = Convert.ToInt32(txtId.Text);
            personelDetail.Name= txtName.Text;
            personelDetail.Age= Convert.ToInt32(txtAge.Text);
            MessageBox.Show("All data set!");


        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            personelDetail.EmployeeID = Convert.ToInt32(txtId.Text);
            personelDetail.Name = txtName.Text;
            personelDetail.Age = Convert.ToInt32(txtAge.Text);
            // making new instance of Form2 class here
            //we name it "frm"
            Form2 frm = new Form2();
            frm.personelDetail= personelDetail;
            frm.ShowDialog();
        }
    }
}
