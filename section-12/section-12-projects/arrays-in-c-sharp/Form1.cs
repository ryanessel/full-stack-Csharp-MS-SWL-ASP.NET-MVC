using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrays_in_c_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] days = new string[]
            {
                "Sunday",
                "Monday",
                "Tuseday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };
           
            for (int i = 0; i < days.Length; i++)
            {
                string rowtext = days[i];
                dataGridView1.Rows.Add(rowtext);
            }

        }

        private void btnMultiArray_Click(object sender, EventArgs e)
        {
            string[,] rows = new string[,]
            {
                {"1", "Sunday" },
                {"2", "Monday" },
                {"3", "Tuseday" },
                {"4", "Wednesday" },
                {"5", "Thursday" },
                {"6", "Friday" },
                {"7", "Saturday" }
            };
            for (int i = 0; i < rows.GetLength(0); i++)
            {
                string[] row = new string[rows.GetLength(1)];

                for (int j = 0; j < rows.GetLength(1); j++)
                {
                    row[j]= rows[i, j];
                }
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
