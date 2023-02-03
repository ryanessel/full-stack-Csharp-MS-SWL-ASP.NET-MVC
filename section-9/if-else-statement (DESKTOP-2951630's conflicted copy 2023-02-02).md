If-else statement

- 3 diffint ways to control conditions
1. if else statement
2. switch case
3. ternary operator

1. if else statement

- single most inmportant condition thing in each programing language
- if statement means a boolean result - true or false
- if condition is true do somehting, else do soemthing else


// example of use
if(//condition)
{
    do snth
}


//every if has ablock (with the {})

if only one line in the block then you don't need curly braces
**Example - Without curly braces**
if(a == 20) b = 45;
**EXAMPLE WITH CURLY BRACES MORE THAN ONE LINE**

if(a<b) 
{
    name ="john";
    control = false;
}

--------------------------

if you write multiple "if"
then all the conditionals will be run

if you only want one to run you use (else if)
--------------------------------------------------------
int a = 20, b = 30;
bool control = true;
string name = "charles";

※Must rgiht most important, or statement with most conditions, to least important, or statement with least or no conditions

// only the code in the "else if (a<=b)" will run
if (a==30)
{
//do something
}

else if (!control)
{
    //do something
}

else if (a<=b)
{
   //do something 
}

else 
{
   //do something 
}


------------------------------------------------------


nested if statement - example
------------------------------------------------------

if (a == 30)
{
    if(control)
    {
        //do something 
    }
    else
    {
        //do something 
    }

}

else if (a >= b)
{
    if(name == "john")
    {
        //do something 
    }
    else
    {
        //do something 
    }

}





------------------------------------------------------



YesNoCancel Dialog Box button
-------------------------------------------------------
		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("do you want to abort?", "if control", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes) 
			{
				textBox1.Text = "YES was chosen";
			}

			else if (result == DialogResult.No) 
			{
				textBox1.Text = "NO was chosen";
			}
			else
			{
				textBox1.Text = "Cancel was chosen";
			}


		}


-------------------------------------------------------



1. ternary operator - example

------------------------------------------------------------------
		private void button4_Click(object sender, EventArgs e)
		{
			int a = 10, b = 20;
			string ternaryresult;
			ternaryresult = a < b ? b.ToString() : a.ToString();
			MessageBox.Show(ternaryresult, "Ternary Result is ... ");
		}

------------------------------------------------------------------