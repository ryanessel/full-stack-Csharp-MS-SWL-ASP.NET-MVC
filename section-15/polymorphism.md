NOTE: Vid stopped at 3:00mins

Polymorphism.
- in c# it means providing an ability to take more than one form
- 1 main pillar of OOP

- in c# shtis means allowing classes to impliment different methods
  that are called the same name

  - provide ability to invoke the methods of derived classes
    through the base class reference during runtime based on our
    requirements


2 types of polymophism in C#
 1. compile time polymorphism
 2. run time poly moorphism



1. compile time polymorphism
 - achieved by method overloading
   and by operator overloading in C-sharp
 - also know as static binding or early binding
 - defining multiple same methods but with differnt
   params (overloading)


OVERLOADING EXAMPLE AGAIN
- have 3 options of how to use the method below
- params dictate tehse methods
------------------------------------------------------------------------
class Employee{
    public int EmployeeID{get; set;}
    public string EmployeeName{get; set;}
    public double EmployeeSalary {get; set;}

    //OVerload method section
    public void SetVals(Int ID){ // base
        EmployeeID = ID;
    }
    public void SetVals(Int Id, string Name){ // level 2
        EmployeeID = ID;
        EmployeeName = Name;
    }
    public void SetVals(int ID, string Name, double Salary){ // level 3
        EmployeeID = ID;
        EmployeeName = Name;
        EmployeeSalary = Salary;
    }
}


// USE EXAMPLE
Employee employee1 = new Employee();
employee1.SetVals(12);
employee1.SetVals(12, "Charles");
employee1.SetVals(12, "Charles", 3500);


------------------------------------------------------------------------









2. runtime poly moorphism
 - is achieved by method overriding, 
   which is known as dynamic binding or late binding


Virtual Method 
- is a method that can be redefined in derived classes
- has an implementation in a base class as well as the derived class.
- used when a methods basic functionality is the same 
- virutual method is created in the base class that can be overridden 
  in the derived class
- all you need to do to create a virtual method in the bass class is just
  using the keyword virtual and then that method is overridden in the derived class using the keyword ovverride.
  -- guess normally you can't edit a class's OG methods in a derived class and in order to do so you must name it "public virtual" when you define the base class
  -- and then in the derived class you call "override" and can edit it's funciton

- when a methd is declared as a virtual method in a base class, then that method can be defined in a base classe and it is optional for the derived class to 
  override that method by using the "override" 


- overriding method also provides more than one form for a method.
- Hence, it is also an example of polymorphism.
- Only have to use "override" if you are changing the funciton/method definition
Base class
-------------------------------------------------------------------------
class Employee{
  public int EmployeeID{get; set;}
  public string EmployeeName{get; set;}
  public double EmployeeSalary {get; set;}
  
  public virtual string SetVals(int ID, string Name, double Salary){
    string messageText = "set three params";
    return messageText;
  }
}
-----------------------------------------------------------------------------

↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓

Derived class
---------------------------------------------------------------------------
class Teacher:Employee{
  public string EmployeePosition {get; set;}
  override public string SetValues(intID, string Name, double Salary){
    string messageText = "set four pararms"; // changing the messageText string so we need override above
    return messageText;
  }
}
----------------------------------------------------------------------------


Overriding

------------------------------------------------------------------------------

Employee employee1 = new Employee();
Teacher teacher1 = new Teacher();
string showMsgText;

showMsgText = employee.SetVals(12, "Ryan", 3500);
MessageBox.Show(showMsgText);

showMsgTxt = teacher1.SetVals(12, "Ryan", 3500);
MessageBox.Show(showMsgTxt);
--------------------------------------------------------------------------------









---------------------------------------------------------------------------------