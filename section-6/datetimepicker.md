Datetimepicker
-give a value of type "datetime"


- allows you to display and collect date and time from the user
  using a specific format

Custom format example

after selecting "Custom"

-dd/MM/yyyy hh:m

**Buttons Acting on the data from the date time picker**

//BUTTON CLICK EVENT!!!!
Button used to show mesage of dateTime picker
------------------------------------------------------------
        private void dateTimeBtn_Click(object sender, EventArgs e)
        {
			string dateTimePickerMessageBoxTitle1 = "Birthday is ... ";
			DateTime birthday = dateTimePicker1.Value;
            //must convert birthday to 
			MessageBox.Show(birthday.ToString(), dateTimePickerMessageBoxTitle1);
        }


------------------------------------------------------------


//BUTTON CLICK EVENT!!!!
//EXPANDED VERSION - 
changees the label on each click giving you both 2 years from that date and 2 yearss before that date

------------------------------------------------------------------------

        private void dateTimeBtn_Click(object sender, EventArgs e)
        {
			string dateTimePickerMessageBoxTitle1 = "Birthday is ... ";
			DateTime birthday = dateTimePicker1.Value;
			label6.Text = birthday.AddYears(2).ToShortDateString();
			label7.Text = birthday.AddYears(-2).ToShortDateString();
			MessageBox.Show(birthday.ToString(), dateTimePickerMessageBoxTitle1);
        }


-------------------------------------------------------------------------

**Datetimepicker event- ValueChanged**


DateTimePicker Sepfific event
ValueChanged Event!
- when you choose a date it automatically brings up a msgBox that showingthe time you picked.
- i think the purpose of this is like you can see you are ale to retreive the date data
- so you could make a "if you are under this age then no entry" kinda thing

-------------------------------------------------------------------------


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
			string valChangMsgBoxTitle = "You picked the following date ...";
			MessageBox.Show(dateTimePicker1.Value.ToShortDateString(), valChangMsgBoxTitle);



        }

-------------------------------------------------------------------------