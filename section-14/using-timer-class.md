Timer class
- executes a block of code repeatedly at a given interval of time 
- execution occurs via a timer event
- for example want to back up a folder every 10mins or write a log file every second
- method that needs to be placed inside the event  of the timer.
- timer class in c# reperesents a timer 
- windows forms also has a timer control that can be dropped into its property set \
- timer has properties and events




TIMER CLASS CODE EXAMPLES
1. progress bar count up
---------------------------------------------------------

		private void btnStart_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}
		//Tick event - created by double cliciing the timer obj or by clicking lighting bolt in properties then double clikign the blank box
        int counter = 0;
		private void timer1_Tick(object sender, EventArgs e)
		{
		// I do or else it throws up an exception that counts one more than the pogress bar counter
		 if (counter <= 60)
			{

				lblTimerReadOut.Text = counter.ToString();
				progressBar1.Value = counter;
				counter++;


			}

			

		}
---------------------------------------------------------


2. progress bar count down
---------------------------------------------------------


		private void btnStart_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}

		//Tick event - create by double cliciing the timer obj or by clicking lighting bolt in properties then double clikign the blank box
		int counter = 60;
		private void timer1_Tick(object sender, EventArgs e)
		{
		// I do or else it throws up an exception that counts one more than the pogress bar counter
		 if (counter >= 0)
			{

				lblTimerReadOut.Text = counter.ToString();
				progressBar1.Value = counter;
				counter--;


			}

			

		}


---------------------------------------------------------


3. progress bar count down (but with message and using timer.Stop() method)
---------------------------------------------------------

		private void btnStart_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}



		//Tick event - create by double cliciing the timer obj or by clicking lighting bolt in properties then double clikign the blank box
		int counter = 60;
		private void timer1_Tick(object sender, EventArgs e)
		{
				lblTimerReadOut.Text = counter.ToString();
				progressBar1.Value = counter;
				counter--;
			if (counter < 0)
			{
				timer1.Stop();
				MessageBox.Show("Timer Stopped/Load Complete", "Status");
			}
		}

		

		private void Form1_Load(object sender, EventArgs e)
		{
			lblTimerReadOut.Text = counter.ToString();
		}
	}



---------------------------------------------------------


4.  progress bar count down with flashing message Btn and counter reset 
    so we don't have to keep restarting the program to see the count again.
---------------------------------------------------------


		private void btnStart_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}

		//Tick event - create by double cliciing the timer obj or by clicking lighting bolt in properties then double clikign the blank box
		int counter = 60;
		private void timer1_Tick(object sender, EventArgs e)
		{
				lblTimerReadOut.Text = counter.ToString();
				progressBar1.Value = counter;
				counter--;
			if (counter < 0)
			{
				timer1.Stop();
				MessageBox.Show("Timer Stopped/Load Complete", "Status");
				counter = 60;
				return;
			}
			if(counter  % 2 == 1) btnMsgFlash.BackColor= Color.Red;
			else btnMsgFlash.BackColor= Color.White;
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lblTimerReadOut.Text = counter.ToString();
		}



---------------------------------------------------------