using System.Transactions;

namespace section_4_variable_conversion
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//IMPLICIT CASTING
			byte x = 12;
			short y = 13;
			int z = 4;
			long t = 5;
			float k = 6;

			k = t; // k's new value is 5 and the "long" was converted to a "float"
			y = x;
			z = y;

			//EXPLICIT CASTING
			double x2 = 24;
			int y2;
			//y2 = (int)x; cast operator way
			y2 = Convert.ToInt32(x2);//convert class(method) way

			//Oher explict examples:
			double x3 = 24;
			int y3 = 12;
			float z3 = 6;
			char t3 = '+';// only '' quotes for C-sharp for chars but for strings it uses ""
			string s = x3.ToString();
			
			s = z3.ToString();
			s = t3.ToString();
			s = y3.ToString();
			Console.WriteLine(s);// obviously + would be would s is because it was last defined as such
			Console.ReadKey();// lets you type something before a key press would take you out of that terminal-esque window



		}
	}
}