using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @abstract
{
    public partial class btnShow : Form
    {
        public btnShow()
        {
            InitializeComponent();
        }


        abstract class Vehicle
        {
            public abstract double getFuelAmount();

        }

        class Bus : Vehicle
        {
            // abstract method of base class must be 
            //overriden or else we get an error
            override public double getFuelAmount()
            {
                return 300;
            }
        }
        class Truck : Vehicle
        {
            public override double getFuelAmount()
            {
                return 500;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";
            Vehicle vc1;
            vc1 = new Bus();
            double busfuel = vc1.getFuelAmount();
            text += "Bus Fuel Amt: " + busfuel.ToString() + Environment.NewLine;
            vc1 = new Truck();
            double truckfuel = vc1.getFuelAmount();
            text += "Truck Fuel Amt: " + truckfuel.ToString() + Environment.NewLine;
            textBox1.Text = text;

        }
    }
}
