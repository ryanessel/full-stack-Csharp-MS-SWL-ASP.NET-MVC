using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace break_point_example_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double txtBoxMidTermExamVal = Convert.ToDouble(txtBoxMidtermExam.Text);
            double txtBoxFinalVal =  Convert.ToDouble(txtBoxFinalExam.Text);

            double gptTotal = (txtBoxMidTermExamVal * 0.4) + (txtBoxFinalVal * 0.6); 
            
            txtBoxGPT.Text = gptTotal.ToString();



           
        }

        private void txtBoxMidtermExam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
