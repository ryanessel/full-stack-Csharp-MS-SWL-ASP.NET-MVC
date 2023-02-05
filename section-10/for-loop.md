for loop
foreach loop


for loops are for things where the number of times the loop should occour is know beforhand

For loop exmaple/syntax
-------------------------------------------------------
for (int i = 0; i < 10; i++) 
{

    MesageBox.Show("I hope you are well!")
}

-------------------------------------------------------


Nested For Loop example 

-------------------------------------------------------
for (int i = 0; i < 10; i++) 
{

    for (int k = 0; k < 10; k++) 
    {
        ivalue += "i: " + " k: " + k + Environmnet.NewLine; 
    }

    textBox1.Text = ivalue;


}

-------------------------------------------------------




Foreach syntax
-------------------------------------------------------
				foreach(var item in collection)
				{

				}

-------------------------------------------------------


Button Examples
1. for loop button example - output appears in the popup window.
-------------------------------------------------------

		private void button1_Click(object sender, EventArgs e)
		{
			string ivalue = "";
			for (int i = 0; i < 30; i++) 
			{
				ivalue += " " +  i + " ";
			}
			MessageBox.Show(ivalue);
		}

-------------------------------------------------------



2.  nested for loop button example - output appears in text box
-------------------------------------------------------

		private void button2_Click(object sender, EventArgs e)
		{
			string ivalue = "";
			for (int i = 0; i < 10; i++)
			{

				for (int k = 0; k < 10; k++)
				{
					ivalue += "i: " + i + " k: " + k + Environment.NewLine;// evnvironment new line gives us a new line for each loop val
				}

				richTextBox1.Text = ivalue;


			}

		}

-------------------------------------------------------



3. 
-------------------------------------------------------



-------------------------------------------------------


