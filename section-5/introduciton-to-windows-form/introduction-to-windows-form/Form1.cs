using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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
			//inside here is what the button will do when clicked.
			//in this case the text of the button whose design
			//name is "firstbutton" will
			//change to "changed" onClick
			firstbutton.Text = "changed";
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("hello", "message title");
		}

		private void button2_KeyPress(object sender, KeyPressEventArgs e)
		{
			// pressing any key will change this button's text to "Enter"
			//when it is highlighted or clicked once (making it highlighted)
			button2.Text = "Enter";
		}


	
		private void button3_Click(object sender, EventArgs e)
		{

			for (int i = 0; i < 10; i++)
			{
				this.WindowState = FormWindowState.Maximized;
				System.Threading.Thread.Sleep(50);
				this.WindowState = FormWindowState.Minimized;
				System.Threading.Thread.Sleep(50);
			}


		}

		private void button4_Click(object sender, EventArgs e)
		{
			label1.Text = "first label";
			label1.BackColor = Color.Green;
			label1.ForeColor= Color.White;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled= true;
			}

			if ((e.KeyChar =='.') && ((sender as  TextBox).Text.IndexOf('.') > -1 ))
			{
				e.Handled = true;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			string labeltext = textBox2.Text;
			label2.Text= labeltext;
			label2.BackColor = Color.Green;
			label2.ForeColor = Color.White;
		}
	}
}
