C-sharp if else example


------------------------------------------------------------------
   string messagetext = "Do you want to close this window?";

	--//adds title to message box--
    
	string messagetitle = "Close Window";
	MessageBoxButtons farts = MessageBoxButtons.YesNo;
	DialogResult result = MessageBox.Show(messagetext, messagetitle, farts);
	if(result == DialogResult.Yes)
	{
		this.Close();
	}
	else if (result == DialogResult.No) 
	{ 
	// do nothing
	}

    ------------------------------------------------------------------


Adds icon to you popup window

		string message = " did you see the icon? ";
		string title = "okay";

		MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);