using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void fillTextBox(int x);
        string textvalue = "";
        public void FillMathNote(int ExamNote)
        {
            textvalue += "Your math note is " + ExamNote + Environment.NewLine;

        }

        public void FillChemistryNote(int ExamNote)
        {
            textvalue += "Your Chemistry note is " + ExamNote + Environment.NewLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void ShowInTextBox()
        {
            textBox1.Text = textvalue;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            fillTextBox filltext = new fillTextBox(FillMathNote);
            filltext += FillChemistryNote;
            filltext(80);
            filltext -= FillMathNote;
            filltext(60);
            ShowInTextBox();

        }
    }
}
