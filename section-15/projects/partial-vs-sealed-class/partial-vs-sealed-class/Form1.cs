using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partial_vs_sealed_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //partial class
        public partial class Employee // partials must have same acces modifers
        {
            public int EmployeeId { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }

        }
        
        public partial class Employee
        {
            public void setValues()
            {
                Name = "Ryan";
                EmployeeId= 1;
                Salary = 2000;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //SEALED CLASS
        public sealed class SealedEmployee
        {

        }
        // trying to extend won't work cause "SealedEmployee" class
        // is sealed 
        public class TestClass : SealedEmployee
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Employee emp1= new Employee();
            emp1.setValues();
            textBox1.Text += emp1.EmployeeId + Environment.NewLine;
            textBox1.Text += emp1.Name + Environment.NewLine;
            textBox1.Text += emp1.Salary + Environment.NewLine;
        }
    }
}
