using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace section_6_scrap_work_project
{
    public partial class frmGetData : Form
    {
        public frmGetData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //making a class instance of fromShowData form
            frmShowData frmShow = new frmShowData();
            //showing the other form on click
            frmShow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //making a class instance of fromShowData form
            frmShowData frmShow = new frmShowData();
            //showing the other form on click
            frmShow.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Name =textName.Text;
            string surename = textSurname.Text;
            string NameSurname = Name + " " +surename;
            frmShowData frmShow = new frmShowData();
            frmShow.lblNameSurname.Text = NameSurname;
            frmShow.Show();


        }
    }
}
