using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introduction_to_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		string message = " did you see the icon? ";
		string title = "okay";

		DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo,MessageBoxIcon.Information);
			if (result == DialogResult.Yes)
			{
				this.Close();
			}
			else if (result == DialogResult.No)
			{
				// do nothing
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
