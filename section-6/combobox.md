combobox
-can hold multiple values at the same time
- like a drop down box in appear abd cna select any vlaue in it
- used to give multiple options to users
- used on sign up forms and has most countries

- using "text" property in Visual Studio will show that text before 
  anything is chosen.

--------------------------------------------
			// getting data from combo box
			// 4 different ways
			// 1. SelectedText
			// 2. SelectedValue
			// 3. SelectedItem
			// 4. SelectedIndex

---------------------------------------------



  // 1. SelectedIndex
Adding items to Comboboxx (multivalue drop down window)
-------------------------------------------------------



			comboBox1.Items.Add("Sunday");
			comboBox1.Items.Add("Monday");
			comboBox1.Items.Add("Tuseday");
            //sets what value to show default using index; its coding so
            //0 is sunday, 1 = monday, 2 = tuseday for example
			comboBox1.SelectedIndex = 2;


-------------------------------------------------------

// 2. SelectedItem

Button click event which shows current item selected in combobox (dropdown)
----------------------------------------------------------

        private void comboBtn1_Click(object sender, EventArgs e)
        {
			string comboMessageBoxTitle = "Current item selected is...";
			// using SelectedItem method, it get the current item selected 
			// in the target comboBox. Ex: yourComboBoxName.SelectedItem
			// the ToString() converts it to a string so it can be displayed 
			// via message boxes
			string selecteditem = comboBox1.SelectedItem.ToString();
			MessageBox.Show(selecteditem, comboMessageBoxTitle );
        }	


-----------------------------------------------------------



// 3. SelectedIndex

- gives you the index of the item currently selected in the comobo box

- gives you an int so like 0, 1, 2 etc.; its an array

---------------------------------------------------------------
        private void comboBtn1_Click(object sender, EventArgs e)
        {
			string comboMessageBoxTitle = "Index of selected item is...";
			int valueorder  = comboBox1.SelectedIndex;
			MessageBox.Show(valueorder.ToString());

        }


----------------------------------------------------------------


4. SelectedValue -- looks like this is an event
