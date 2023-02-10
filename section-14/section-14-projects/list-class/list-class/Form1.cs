using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_class
{
    public partial class btnFillList : Form
    {
        public btnFillList()
        {
            InitializeComponent();
        }
		//list set up here
		List<int> numList= new List<int>();
		List<string> textList = new List<string>();
		List<Employee> employeeList = new List<Employee>();
		
		//will add 3 numbers to the "numList" list
		void fillList()
		{
			numList.Add(1);
			numList.Add(2);
			numList.Add(3);
		}
		//funciton used to create and fill out employee objs then add them to the "employeeList" list (it clears them so yo ucan do it agian)
		public List<Employee> empFillList()
		{
			employeeList.Clear();// clearing the list then creating employee with details then adding to list and returning that list
			// Creating Instances of Employee class obj
			Employee employee1 = new Employee();
			employee1.ID = 1;//Adding vals to the props of our newly created class instance obj
			employee1.FristName = "Ryan";
			employee1.LastName = "Essel";
			employeeList.Add(employee1);// adding out employee to the employeelist list
			Employee employee2 = new Employee();
			employee2.ID = 2;
			employee2.FristName = "Shrek";
			employee2.LastName = "Myers";
			employeeList.Add(employee2);
			Employee employee3 = new Employee();
			employee3.ID = 3;
			employee3.FristName = "Donkey";
			employee3.LastName = "Murphy";
			employeeList.Add(employee3);
			return employeeList;
		}
		private void Form1_Load(object sender, EventArgs e)
		{


		}

		private void button1_Click(object sender, EventArgs e)
		{
			fillList();
			MessageBox.Show("List was filled", "Fill Button Result..");
		}

		private void btnFillListToTextBox_Click(object sender, EventArgs e)
		{

			fillList();

			for (int i = 0;i < numList.Count; i++) {
			
				txtNumber.Text += numList[i].ToString() + Environment.NewLine;

			}
			//MessageBox.Show("List was filled", "Fill Button Result..");

		}

		private void btnForEachTxtFill_Click(object sender, EventArgs e)
		{

			fillList();

			foreach (var item in numList)
			{
				txtNumber.Text += item.ToString() + Environment.NewLine;
			}
		}

		private void btnAddEmployeetToList_Click(object sender, EventArgs e)
		{
			empFillList();
			foreach (var employee in employeeList)
			{
				txtNumber.Text += employee.ID + employee.FristName + employee.LastName + Environment.NewLine;
			}
		}
	}
}
