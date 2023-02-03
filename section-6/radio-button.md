radio button

radio button event. When checked it bring the message box up 
the commented out bits make it not checked/or checkable when the progrma loads
----------------------------------------------------------------
        private void radioBtn1_CheckedChanged(object sender, EventArgs e)
        {
            //This shows you have to save a boolean as a variable.
			//radioBtn1.Checked = false;
			//bool control = radioBtn1.Checked;
			MessageBox.Show("Checked changed", "Radio Button 1");
        }
    }

----------------------------------------------------------------