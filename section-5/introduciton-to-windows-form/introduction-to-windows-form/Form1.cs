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
			comboBox1.Items.Add("Sunday");
			comboBox1.Items.Add("Monday");
			comboBox1.Items.Add("Tuseday");
            //comboBox1.SelectedIndex = 2;  // <--- if this is un commented it will immediatly cause the
			//comobo box to receive a change making it so that our labels change 
			// by just loading the form
            // getting data from combo box
            // 4 different ways
            // 1. SelectedText
            // 2. SelectedValue
            // 3. SelectedItem
            // 4. SelectedIndex






            //makes it so this check box is alwayas checked
            checkBox1.Checked = true;
            // this is how to hold line above in a var
            bool control = checkBox1.Checked = true;

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

        private void radioBtn1_CheckedChanged(object sender, EventArgs e)
        {
			//radioBtn1.Checked = false;
			//bool control = radioBtn1.Checked;
			MessageBox.Show("Checked changed", "Radio Button 1");
        }

		//Checked Changed
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

			MessageBox.Show("Check changed", "Checkbox Message Box");

        }

		//CheckState Changed event
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Checked state changed", "Check state changed");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			label4.Text = "combobox selected index";

        }

        private void comboBtn1_Click(object sender, EventArgs e)
        {
            string comboMessageBoxTitle = "Current item selected is...";
            // using SelectedItem method, it get the current item selected 
            // in the target comboBox. Ex: yourComboBoxName.SelectedItem
            // the ToString() converts it to a string so it can be displayed 
            // via message boxes
            string selecteditem = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selecteditem, comboMessageBoxTitle);

        }

        private void comboBoxIndexSel_Click(object sender, EventArgs e)
        {
            string comboMessageBoxTitle = "Index of selected item is...";
            int valueorder = comboBox1.SelectedIndex;
            MessageBox.Show(valueorder.ToString(), comboMessageBoxTitle);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
			label5.Text = "combobox selected value changed";
        }
    }
}
