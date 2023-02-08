Developing a c plus project



			//works like the x button on a window; exits the window
			Application.Exit();




	//Key Press event to prevent user from typing letters and only allows digits
	//※NOTE: on a text box you have to go to events (⚡)　and go to "keypress" then 
	// double click so that it bring up the code page. the copy and past everthing from
	   the "if" statement 

	    private void cmbDivisibleTerm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))

            {
                e.Handled = true;
            }
        }



// Making radio buttons so the others are deselected if one is selected
//※NOTE: Got to double click on CheckedChanged event (⚡) and input the if state
          ments respectivly
// varName.ForeColor = Color.anyColor; -- changes the text color of the targeted
   element. Replace "varName" with your variable name and "anyColor" with a color
   that MCV recognizes

-------------------------------------------------------------------------------
        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
			if(rbBlack.Checked)
			{
				rbRed.Checked = false;
                rbBlue.Checked = false;
                rbGreen.Checked = false;
				txtDivisibleNumbers.ForeColor = Color.Black;

            }
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
			if(rbRed.Checked)
			{
				rbBlack.Checked = false;
                rbBlue.Checked = false;
                rbGreen.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Red;
            }
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
			if(rbBlue.Checked)
			{
				rbBlack.Checked = false;
                rbRed.Checked = false;
                rbGreen.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Blue;
            }
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
			if(rbGreen.Checked)
			{
				rbBlack.Checked = false;
				rbRed.Checked = false;
				rbBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Green;
            }
        }
------------------------------------------------------------------------------------



//Check boxes that bolds and/or italicises text in a text box
//again CheckedChange event ⚡　then set it up like below.
//it accounts for checked and unchecked for both styles
------------------------------------------------------------------------------------
        private void chBold_CheckedChanged(object sender, EventArgs e)
        {
			if (chBold.Checked)
			{
				txtDivisibleNumbers.Font = new Font(
					txtDivisibleNumbers.Font.FontFamily,
					txtDivisibleNumbers.Font.Size,
					FontStyle.Bold
					);
			}
			else
			{
                txtDivisibleNumbers.Font = new Font(
                    txtDivisibleNumbers.Font.FontFamily,
                    txtDivisibleNumbers.Font.Size,
                    FontStyle.Regular
                    );
            }
        }

        private void chItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chItalic.Checked)
            {
                txtDivisibleNumbers.Font = new Font(
                    txtDivisibleNumbers.Font.FontFamily,
                    txtDivisibleNumbers.Font.Size,
                    FontStyle.Italic
                    );
            }
            else
            {
                txtDivisibleNumbers.Font = new Font(
                    txtDivisibleNumbers.Font.FontFamily,
                    txtDivisibleNumbers.Font.Size,
                    FontStyle.Regular
                    );
            }
        }
------------------------------------------------------------------------------------