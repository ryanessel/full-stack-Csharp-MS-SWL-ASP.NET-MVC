BUTTON


**How code for Button looks in C#**
-------------------------------------------------
private void button1_Click(object senderEventArgs e)
{
    //inside here is what the button will do when clicked.
    //in this case the text of the button whose design name is "firstbutton" will change to "changed" onClick
	firstbutton.Text = "changed";
}
-------------------------------------------------

**Button with click event that shows message"**
-------------------------------------------------
private void button1_Click_1(objecsender, EventArgs e)
{
    //pops up a message window with title of your choice when user clicks this button
	MessageBox.Show("hello", "message title");
}

-------------------------------------------------

**Key Press event for button (if highlighted using tab or clicking on it once)**
-------------------------------------------------

private void button2_KeyPress(objecsender, KeyPressEventArgs e)
{
	// pressing any key will change thibutton's text to "Enter"
	//when it is highlighted or clickeonce (making it highlighted)
	button2.Text = "Enter";
}

-------------------------------------------------

BONUS OPEN - CLOSE WINDOW LOOP BUTTON 

-------------------------------------------------

private void button3_Click(object senderEventArgs e)
{

	for (int i = 0; i < 10; i++)
	{
		this.WindowState = FormWindowState.Maximized;
		System.Threading.Thread.Sleep(50);
		this.WindowState = FormWindowState.Minimized;
		System.Threading.Thread.Sleep(50);
	}
}

-------------------------------------------------