using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

		private void Form1_Load(object sender, EventArgs e)
		{

		}
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
}
