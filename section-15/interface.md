Interface
- is almost the same as class but, the only difference 
  is the class can contain both declarations and implimentation
  of methods, properties and events


-  Interface will only contain the declarations of methods, 
   propperties and event that a class or struct can impliment


Syntax/Example Code- Interface
------------------------------------------
interface Computers
{
    void GetLaptops();
    void GetDesktops();
}

--------------------------------------------


- Interface in C sharop is more like a contract, and
  the class or struct that implements an interface
  must provide an implementation for all the memebers that
  are specified in the interface definition

- C# will not support multiple inheritance of classes but,
  that can be achoived by using the interface.


Implement an interface into a class or a structure lie below:

--------------------------------------------------------------
interface Computers
{
    void GetLaptops();
    void GetDesktops();
}

class DellComputers:Computers
{
    void Computers.GetLaptops(){} // we have to define methods in class like this
    void Computers.GetDesktops(){}
}

// you can't call Computers computer1 = new Computers(); because it is an interface. you have to do like below:
Computers computer1 = new DellComputers();

--------------------------------------------------------------


In C# an interface cannot be instatiated directly, 
but it can be instantiated by a class or a struct
that implements an interface
-------------------------------------------------------

Computers computer1 = new DellComputers();


--------------------------------------------------------

In C# a class can inherit but only from one class but,
we can implement a multiple number of interfaces
- interface cant contain constants, fields, operators, instance constructors,
  finalizers or types
- mainly it is used for methods i think 
-----------------------------------------------------
interface Computers // by default interface are "public" and we can't add other access modifers
{
    void GetLaptops();
    void GetDesktops();
}

interface Laptop
{
    void GetName();
}

class DellComputers:Computers, Laptop// implementing mutiple interfaces doing comma 
{
    void Computers.GetLaoptops(){}
    void Computers.GetDesktops(){}
    void Laptop.GetName(){}
}
-----------------------------------------------------


Code Examples


1. shows interface and using mutliple interfaces
------------------------------------------------------------------------

		interface Computers
		{
			void GetDesktops();
			void GetLaptops();
		}
		class DellComputers : Computers, DellComputer // need to write method or it will throw an error
		{
			public string Name { get; set; }
			public double Price { get; set; }
			public string Mark { get; set; }

			public void GetDesktops()
			{
				Name = "Desktop1";
				Price = 2000;
			}

			public void GetLaptops()
			{
				Name = "Laptop1";
				Price= 1500;
			}

			public void GetMark()
			{
				Mark = "Dell";
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		interface DellComputer
		{
			void GetMark();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DellComputers dell1 = new DellComputers();
			dell1.GetLaptops();
			dell1.GetMark();
			string textvalue = "Name: " + dell1.Name + Environment.NewLine;
			textvalue += "Price: " + dell1.Price + Environment.NewLine;
			textvalue += "Mark: " + dell1.Mark;
			textBox1.Text += textvalue;
		}
------------------------------------------------------------------------

