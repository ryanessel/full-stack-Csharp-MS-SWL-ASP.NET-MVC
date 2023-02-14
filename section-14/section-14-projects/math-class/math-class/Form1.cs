using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt1stNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
             e.Handled= true;
            }
            
            if((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-')>-1)) 
            { 
            e.Handled = true;  
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }



        }

        private void txt2ndNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2ndNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
        double firstNumber = 0, secondNumber = 0;
        bool control = false;
        void set1Parameter(string text)
        {
         if(text.Trim()!="")
            {
                control = true;
                firstNumber= Convert.ToDouble(text);
            }
         else { control = false; }
        }
        //Clear button - resets all vals on the calc to 0
        private void button1_Click(object sender, EventArgs e)
        {
            control = false;
            txt1stNum.Clear();
            txt2ndNum.Clear();
            txtResult.Clear();
            firstNumber = 0;
            secondNumber = 0;
        }
        string message = "Please fill nessecary fields!";
        string msgTitle = "※Notice※";
        public void DisplayMessage()
        {
            MessageBox.Show(message, msgTitle);
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            set2Parameter(txt1stNum.Text, txt2ndNum.Text);
            if(!control)
            {
                MessageBox.Show(message, msgTitle);
            }
            else
            {
                txtResult.Text = Math.Min(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber)).ToString();

            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            set2Parameter(txt1stNum.Text, txt2ndNum.Text);
            if(!control) 
            {
                MessageBox.Show(message, msgTitle);
            } else
            {
                txtResult.Text = Math.Max(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber)).ToString();
            }
        }
        //converts all numbers to positive
        private void btnAbs_Click(object sender, EventArgs e)
        {
            set1Parameter(txt1stNum.Text);
            if(!control)
            {
                MessageBox.Show(message, msgTitle);
            } else
            {
                txtResult.Text = Math.Abs(firstNumber).ToString();
            }
        }
        //shows if positive or negatiive?
        private void btnSign_Click(object sender, EventArgs e)
        {
            set1Parameter(txt1stNum.Text);
            if(!control)
            {
                MessageBox.Show(message, msgTitle);
            }
            else
            {
                txtResult.Text=Math.Sign(Convert.ToDecimal(firstNumber)).ToString();
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            set1Parameter(txt1stNum.Text);
            if(!control)
            {
                MessageBox.Show(message, msgTitle);
            }
            else
            {
                double temp = (firstNumber * (Math.PI)) / 100 ;
                txtResult.Text = Math.Sin(temp).ToString();
                
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            set1Parameter(txt1stNum.Text);
            if(!control)
            {
                DisplayMessage();
            }
            else
            {
                double temp = (firstNumber * (Math.PI)) / 100;
                txtResult.Text = Math.Cos(temp).ToString();
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            set1Parameter(txt1stNum.Text);
            if(!control)
            {
                DisplayMessage();
            }
            else
            {
                double temp = (firstNumber * (Math.PI)) / 100;
                txtResult.Text = Math.Tan(temp).ToString();
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            set2Parameter(txt1stNum.Text, txt2ndNum.Text);
            if(!control)
            {
                DisplayMessage();
            }
            else
            {
                txtResult.Text = Math.Pow(firstNumber, secondNumber).ToString();

            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            set1Parameter(txt1stNum.Text);
            if (!control)
            {
                DisplayMessage();
            }
            else
            {
                txtResult.Text = Math.Sqrt(firstNumber).ToString();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            set2Parameter(txt1stNum.Text, txt2ndNum.Text);
            if(!control)
            {
                DisplayMessage();
            }
            else
            {
                txtResult.Text= Math.Log(secondNumber, firstNumber).ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            set1Parameter(txt1stNum.Text);
            if(!control)
            {
                DisplayMessage();
            }
            else
            {
                txtResult.Text =Math.Log10(firstNumber).ToString();
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            set1Parameter(txt1stNum.Text);
            if (!control)
            {
                DisplayMessage();
            }
            else
            {
                txtResult.Text = Math.Exp(firstNumber).ToString();
            }
        }
        // this takes the result of any calculation you've dont
        // then puts it in the 1st numb box
        //also clearing the result and 2nd number so you can use
        // that result with a different calculation
        private void btnCopyFirstNumber_Click(object sender, EventArgs e)
        {
         if(txtResult.Text.Trim()!="")
            {
                txt1stNum.Text = txtResult.Text;
                txtResult.Clear();
                txt2ndNum.Text = txtResult.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void set2Parameter(string text, string text2)
        {
            if (text.Trim()!="" && text2.Trim()!="")
            {
                control = true;
                firstNumber= Convert.ToDouble(text);
                secondNumber= Convert.ToDouble(text2);
            }
        }
    }
}
