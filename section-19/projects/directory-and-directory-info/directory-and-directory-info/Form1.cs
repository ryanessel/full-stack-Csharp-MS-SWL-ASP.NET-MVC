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
namespace directory_and_directory_info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists("folder2"))
            {
                Directory.CreateDirectory("folder2");
            }
        
        }

        private void btnMoveFolder_Click(object sender, EventArgs e)
        {   // moving a folder
            Directory.Move("temp", @"C:\newfolder\temp");// you must give it the same name or different name for when you move it into a new foloder
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Directory.Delete("temp2");
        }

        private void btnCreate2_Click(object sender, EventArgs e)
        {
            DirectoryInfo dr1 = new DirectoryInfo("folder3");
            dr1.Create();
            string accesstime = dr1.LastAccessTime.ToString();
            string createtime = dr1.CreationTime.ToString();
            MessageBox.Show(accesstime, "Last Accessed at ...");
            MessageBox.Show(createtime, "Created at/on ...");
        }
    }
}
