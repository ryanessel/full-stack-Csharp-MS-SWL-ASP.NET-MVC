Random Class


used for practical things like usable random numbers  - like a password generator

-random class - represents a sudo number generator
                uses modified version of donald e neuths subtractive random number generator algorithym

- can use random class after in cludering the reference for the system name sapce 
3 Methods of random class
- Next
- NextDouble
- NextBytes


Declaring a Random Class instance
Random random - new Random();


1. Next(); - capacity (int)

Next() can any number from zero between int type range (or capacity)
Next(param) - gives a random number from zero to param
Next(param1, param2) - gives random nubmer between param1 and param2






2. NextDouble
double randomNumber = random.NextDouble(); gives you a random number from zero to 1 (decimal)





3. NextBytes - this method returns a byte array
byte[] Array = new byte[10];
random.NextBytes(Array); // put an array in here and each index will have a random number



CODE EXAMPLES

.Next(params, params) and .NextDouble(), example 
----------------------------------------------------------
		private void btnRandom_Click(object sender, EventArgs e)
		{	//when you press the button it makes the label have a random numbwer
			//declareing new instance of "Random" class
			Random rnd= new Random();
			label1.Text = rnd.Next(1, 10).ToString();
			label2.Text = rnd.Next(1, 10).ToString();
			label3.Text = rnd.Next(1, 10).ToString();
			label4.Text = rnd.Next(1, 10).ToString();
			// gives you a random decimal between 0 and 1
			label5.Text = rnd.NextDouble().ToString();

		}

----------------------------------------------------------


.NextBytes(Arr) - example
using random class varible to make an array with no values but a capacity of 5 have all random numbers at each of the indecies
----------------------------------------------------------

		private void btnByte_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			// creates and array of random numbers
			byte[] ArrayOfNums = new byte[5];

			rnd.NextBytes(ArrayOfNums);
			
			label6.Text = ArrayOfNums[0].ToString();
			label7.Text = ArrayOfNums[1].ToString();
			label8.Text = ArrayOfNums[2].ToString();
			label9.Text = ArrayOfNums[3].ToString();
			label10.Text = ArrayOfNums[4].ToString();

		}

----------------------------------------------------------








RANDOM PASSWORD GENERATOR BUTTON
----------------------------------------------------------


		//random password generator button
		private void btnPasswordGenerator_Click(object sender, EventArgs e)
		{
			string allValid = "ZDTXZFPYQEOUPGMEIYCEUSK";
			string result = "";
			Random rnd2 = new Random();
			for (int i = 0; i < 6; i++)
			{
				result += allValid[rnd2.Next(0, Convert.ToInt32(allValid.Length))];
			}
			passWordLabel.Text = result;
		}
	}


----------------------------------------------------------