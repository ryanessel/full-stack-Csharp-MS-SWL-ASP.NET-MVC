using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exception_handling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void btnDivide_Click(object sender, EventArgs e)
		{
			try
			{
				int result = Convert.ToInt32(txtFirstNumber.Text) / Convert.ToInt32(txtSecondNumber.Text);
			}
			catch (DivideByZeroException ex)
			{
				// throw is for to show the error in the program
				throw new Exception("srry bby u can't divide by zero lol");
			}
			catch (Exception ex)
			{
				// throw is for to show the error in the program
				throw new Exception("Please use only numbers ");
			}
			finally
			{
				MessageBox.Show("Program was finished");
			}
			
		}
	}
}
