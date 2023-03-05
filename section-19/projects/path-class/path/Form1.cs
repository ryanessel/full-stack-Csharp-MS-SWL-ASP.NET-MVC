using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace path
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnShow_Click(object sender, EventArgs e)
		{
			string myfile = @"C:\test\photo.jpg";
			txtShow.Text += Path.GetDirectoryName(myfile) + Environment.NewLine;
			txtShow.Text += Path.GetExtension(myfile) + Environment.NewLine;
			txtShow.Text += Path.GetFileName(myfile) + Environment.NewLine;
			txtShow.Text += Path.GetFileNameWithoutExtension(myfile) + Environment.NewLine;
			txtShow.Text += Path.GetPathRoot(myfile) + Environment.NewLine;
			txtShow.Text += Path.GetFullPath(myfile) + Environment.NewLine;
		}
	}
}
