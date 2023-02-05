While and do while loop

- this used to do the same task over and over

2 categories
1. entry controlled loops
2. exist controlledl oops



1. entry controlled loops - while loop and for loop are examples of this
- in which with the condition to be tested in present in the beginning of the loop body


2. exist controlled loops - do while
- testing condition is present at the end of the loop body
- will be evaluted at least 1 time


while loop -syntax
----------------------------------------------------
while (condition)
{
    //loop block
}
----------------------------------------------------


while loop- example; - should give you 10 times
--------------------------------------------------------------------------------------------------------
int loopWorkAmount = 0;
int loopControlValue = 10;

while(loopControlValue < 20)
{
    loopWorkAmount++;
    loopControlValue++;
}
MessageBox.Show("Out loop work" + loopWorkAmount.ToString() + " times");
--------------------------------------------------------------------------------------------------------



Nested While Loop 
--------------------------------------------------------------------------------------------------------
int outLoopWorkAmount = 0;
int outLoopControlValue = 10;

int inLoopWorkAmount = 0;
int inLoopControlValue = 0;

while (outLoopControlValue<20)
{
    inloopControlValue =0;
    outLoopWorkAmount++;

    while(inLoopControlValue<8)
    {
        inLoopControlValue++;
        inLoopWorkAmount++;
    }
    outLoopControlValue++;
}
MessageBox.Show(
"Out loop worked " + outLoopWorkAmount.ToString() + " times " +
" In Loop worked " + inLoopWorkAmount.ToString() + " times " 

);

--------------------------------------------------------------------------------------------------------


Do While Loop syntax - evaluates loop condition after the loop runs onces --- i think
--------------------------------------------------------------------------------------------------------
do
{
    // loop block
} while (condition);



--------------------------------------------------------------------------------------------------------




Do While Loop - example - should run 11 times?
--------------------------------------------------------------------------------------------------------
int loopWorkAmount =0;
int loopControlValue = 10;

do
{
    loopWorkAmount++;
    loopControlValue++;
} while(loopControlValue < 20);

MessageBox.Show(
"Out Loop worked " +
loopWorkAmount.ToString() +
" times"
)


--------------------------------------------------------------------------------------------------------



NEsted while loop example 



--------------------------------------------------------------------------------------------------------

		private void button3_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			int inLoopWorkAmount = 0, inLoopControlValue = 0;
			int outLoopControlValue=10, outLoopWorkAmount = 0;
			while(outLoopControlValue<20)
			{
				inLoopControlValue = 0;
				while(inLoopControlValue < 8)
				{
					inLoopControlValue++;
					inLoopWorkAmount++;
					textBox1.Text += outLoopControlValue.ToString() + " " + inLoopControlValue.ToString() +
						Environment.NewLine;
				}
				outLoopControlValue++;
				outLoopWorkAmount++;

			}
			MessageBox.Show("outloopwork amount works " + outLoopWorkAmount.ToString() + 
				" times.  In loop work amount worked " + inLoopWorkAmount.ToString());
		}

--------------------------------------------------------------------------------------------------------










do while button example
- you need += or else it won't print out everything to the multiline text box
**text box is set to "multiline" in its proerties**

--------------------------------------------------------------------------------------------------------
		private void button1_Click(object sender, EventArgs e)
		{
			int loopWorkAmount = 0, loopControlValue = 10;
			while (loopControlValue<20)
			{
				textBox1.Text += loopWorkAmount.ToString() + Environment.NewLine;
				loopControlValue++;
				loopWorkAmount++;
			}
			MessageBox.Show(loopWorkAmount.ToString());
		}
--------------------------------------------------------------------------------------------------------