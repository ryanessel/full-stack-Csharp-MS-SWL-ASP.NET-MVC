Switch Case Statement

-execuite set of logic  depending on the value of given params (its a set of logic)

1. Example Switch case

----------------------------------------------------------------
int x= 6;
string messageText ="";
switch(x)
{
    case 2:
        messageText = "x eqauls 2";
        break;

    case 4:
        messageText = "x eqauls 4";
        break;   

    case 6:
        messageText = "x eqauls 6";
        break;

        
    default:
        messageText = "x eqauls 8";
        break;
}

----------------------------------------------------------------



2. Example  NESTED Switch case

----------------------------------------------------------------
int x= 6, y = 3;
string messageText ="";
switch(x)
{

    case 4:
        messageText = "x eqauls 4";
        break;   

    case 6:
        messageText = "x eqauls 6";
        switch(y)
        {
            case:1
                messageText += "y equals 1";
                break;
            case:2
                messageText = "y equals 2";
                break;
            case:3
                messageText = "y equals 3";
                break;
            default:
                messageText = "y equals 4";
                break;
        }
        break;
    default:
        messageText = "x eqauls 8";
        break;
}

----------------------------------------------------------------


3. Example Switch Case for Button


----------------------------------------------------------------
		private void button1_Click(object sender, EventArgs e)
		{
			string messagetext = "";

			switch (Convert.ToInt32(textBox1.Text))
			{
				case 2:
					messagetext = "x=2";
					break;

				case 4:
					messagetext = "x=4";
					break;

				case 6:
					messagetext = "x=6";
					break;

				default:
					messagetext = "x=8";
					break;
			}
			MessageBox.Show(messagetext, "Your input is ...");
		}
----------------------------------------------------------------


4. Example nested Switch case for button

----------------------------------------------------------------------------

		private void button1_Click(object sender, EventArgs e)
		{
			string messagetext = "";

			switch (Convert.ToInt32(textBox1.Text))
			{
				case 2:
					messagetext = "x=2";
					break;

				case 4:
					messagetext = "x=4";
					break;

				case 6:
					messagetext = "x=6";
					switch(Convert.ToInt32(textBox2.Text))
					{

						case 1:
							messagetext += " y=1";
							break;
						case 2:
							messagetext += " y=2";
							break;
						default:
							messagetext += " y=3";
							break;
					}
					break;

				default:
					messagetext = "x=8";
					break;
			}
			MessageBox.Show(messagetext, "Your x and y values are ...");
		}
----------------------------------------------------------------------------