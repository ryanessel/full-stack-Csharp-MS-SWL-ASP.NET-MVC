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
		List<days> comboList = new List<days>();

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
		    days day1= new days();
		    day1.ID = 1;
		    day1.textvalue = "Sunday";
		    comboList.Add(day1);

			days day2 = new days();
			day2.ID = 2;
			day2.textvalue = "Monday";
			comboList.Add(day2);

			days day3 = new days();
			day3.ID = 3;
			day3.textvalue = "Tuseday";
			comboList.Add(day3);

			days day4 = new days();
			day4.ID = 4;
			day4.textvalue = "Wednesday";
			comboList.Add(day4);

			days day5 = new days();
			day5.ID = 5;
			day5.textvalue = "Thursday";
			comboList.Add(day5);

			days day6 = new days();
			day6.ID = 6;
			day6.textvalue = "Friday";
			comboList.Add(day6);
			//REGULAR WAY TO ADD OBJECT TO LIST
			//days day7 = new days();
			//day7.ID = 7;
			//day7.textvalue = "Saturday";
			//comboList.Add(day7);

			//CONSICE WAY TO ADD CLASS OBJECT TO A LIST!
			comboList.Add(new days() { ID= 7, textvalue= "Saturday" });
			cmbDays.DataSource = comboList;
			// the data value will be the ID to the corresponding displayed text (sunday is 1 etc..)
			cmbDays.ValueMember = "ID";
			cmbDays.DisplayMember= "textvalue";

			dayslist.DataSource = comboList;
			 




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
				txtNumber.Text += employee.ID + " " + employee.FristName + " " + employee.LastName + Environment.NewLine;
			}
		}

		private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
		{
			MessageBox.Show(cmbDays.SelectedValue.ToString(), cmbDays.Text + " ID is ...");
		}
	}
}
