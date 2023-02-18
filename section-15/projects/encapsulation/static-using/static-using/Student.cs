using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace static_using
{
	internal class Student
	{
		public static int StudentNum { get; set; }
		public static void getAddNote()
		{
			MessageBox.Show("Static");
		}
	}
}
