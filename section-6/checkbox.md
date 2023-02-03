checkbox - can have multiple selected


This isn't an event, this is check you put it inside the 

// this bit below is kind of like the canvas for your code
// all coding will go inside the practis of this bit of code below
private void Form1_Load(object sender, EventArgs e)
{


}


-------------------------------------------------------------

            //makes it so this check box is alwayas checked
            checkBox1.Checked = true;
            // this is how to hold line above in a var
            bool control = checkBox1.Checked = true;


-------------------------------------------------------------





//Checked Changed - checkbox event- both of these are the same i think
- when clicked (or when cheked or unchecked) it does whats in the brackets
in this case, it shows the message box with the message and the title
--------------------------------------------------------------------------------
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
			MessageBox.Show("Check changed", "Checkbox Message Box");
        }

----------------------------------------------------------------------------------


//CheckState Changed event - checkbox event- both of these are the same i think
----------------------------------------------------------------------------------
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Checked state changed", "Check state changed");
        }
----------------------------------------------------------------------------