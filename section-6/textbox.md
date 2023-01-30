Textbox 

textbox - max character count is 32767

rich textbox - max char count is  2147483647

-purpose is to get relevant input from the user

Limiting text box to only be able to take numbers and 1 single "."

-------------------------------------

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


-------------------------------------

button that changes target label based on text in target text box

-------------------------------------   
		private void button5_Click(object sender, EventArgs e)
		{
			string labeltext = textBox1.Text;
			label2.Text= labeltext;
			label2.BackColor = Color.Green;
			label2.ForeColor = Color.White;
		}

-------------------------------------