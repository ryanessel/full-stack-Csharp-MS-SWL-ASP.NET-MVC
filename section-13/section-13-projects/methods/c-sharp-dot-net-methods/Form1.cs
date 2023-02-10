using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_dot_net_methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void HideRadioButtons()
        {
            groupBox1.Visible= false;
        }

        public void ClearAllTexts()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        public void FillTextBox(string text )
        {
            textBox2.Text = text;
 
        }

        public void SetNumber (int age ) 
        {
            label1.Text = "You are " + age.ToString() + " years old";
        }
        
        string GetName()
        {
            string name = "Ryan Essel";
            return name;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HideRadioButtons();
            ClearAllTexts();
        }

        int Sum(int x, int y)
        {
            int result = x + y;
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // you are putting in your own text
            //but it the text is determined by what is in
            // the textBox1.
            // this funciton replaces the text in the textBox2
            //with the params text
            FillTextBox(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetNumber(Convert.ToInt32(textBox2.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = GetName();
            MessageBox.Show(
                name, 
                "Your name is ...", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Asterisk
                );
        }

        //overloading example
        string ValueControl()
        {
            string text = "";
            return text;

        }
        string ValueControl(string name)
        {
            // make sure you pass the param down here
            string text = name;
            return text;

        }
        string ValueControl(string name, bool control)
        {
            // make sure you pass the param down here
            string text = name;
            return text +" " + control;

        }




        private void button5_Click(object sender, EventArgs e)
        {
            int result = Sum(
                Convert.ToInt32(textBox1.Text),
                Convert.ToInt32(textBox2.Text)
                );
            MessageBox.Show(
                Convert.ToString(result),// or result.ToString();
                "The Sum of text box 1 and 2 is ..."
                ); ;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string yourName = ValueControl("John", true);
            MessageBox.Show(
                yourName,
                "Method Overload Example"
                );
        }
    }
}
