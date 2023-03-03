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

namespace file_and_fileinfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void btnCreate_Click(object sender, EventArgs e)
		{
			// simply creates a file 
			//File.Create("test-file-1.txt");


			if (File.Exists("test-file-2.txt"))
			{
				MessageBox.Show("A file with this name already exists!", "Notice!");
				return;
			}

			if (!File.Exists("test-file-2.txt"))
			{
				FileInfo ourfile = new FileInfo("test-file-2.txt");

				ourfile.Create();

			}



		}

		private void btnDelFirstFile_Click(object sender, EventArgs e)
		{
			// the text in side the quotation marks must be exact! evne down to the file extension.
			File.Delete("test-file-1.txt");
		}

		private void btnWrite_Click(object sender, EventArgs e)
		{
			// sets up file stream
			FileStream fs1 = new FileStream("third.txt", FileMode.OpenOrCreate, FileAccess.Write);
			//lets you write to the spefific file stream
			StreamWriter sw1 = new StreamWriter(fs1);
			// writing multiple lines
			sw1.WriteLine("This is the first line");
			sw1.WriteLine("This is the 2nd line");
			sw1.WriteLine("This is the 3rd line");
			sw1.WriteLine("This is the 4th line");
			// moves text from temp to file
			sw1.Flush();
			// must clsoe FileStream or we won't be able to see the text in the file.
			fs1.Close();


		}

		private void btnRead_Click(object sender, EventArgs e)
		{
			// FileStream instance obj
			FileStream fsReadTest = new FileStream("third.txt", FileMode.Open, FileAccess.Read);
			// setting up stream reader to handle the above FileStream
			StreamReader sr1 = new StreamReader(fsReadTest);
			string text = "";
			while (!sr1.EndOfStream)
			{
				text += sr1.ReadLine() + Environment.NewLine;
			}
			
			sr1.Close();
			fsReadTest.Close();
			textBox1.Text= text;
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			File.Copy("test-file-2.txt", @"C:\test\test-file-2.txt");
		}

		private void btnProperty_Click(object sender, EventArgs e)
		{
			FileInfo ourfile = new FileInfo("test-file-2.txt");
			string name =  ourfile.Name; // gives file name as string
			string fullname = ourfile.FullName; // gives full file path as string!
			string lastaccesstime = ourfile.LastAccessTime.ToString();// shows last time it was accessed/opened? 
			MessageBox.Show(name, "File Name ");
			MessageBox.Show(fullname, "Full File Name ");
			MessageBox.Show(lastaccesstime, "Last Accessed At ... ");

		}
	}
}
