Static Statement
- "static" is a keyword that can be used to declare a memeber of a type
   that is specific to that type. So that when a memeber is declared static
   it can be accessed with the name of its class directly
-  Without "static" if we wanted to use a variable in a class 
   we would have to create an object first but, if we first define
   this variable as static then we can use it without creating a an obj.

Static Modifier
- can be used with:
  1. a variable - Static variable
  2. a method - Static method
  3. a constructor - Static constructor
  4. a class - Static class

**VARIABLE**
  Non-static variable
  -------------------------------------------------------
  class Employee{
    public string Name {get; set;}
  }
  private void Form1_Load(object sender, EventArgs e){
    Employee employee1 = new Employee();//Makeing an instance of a class Employee named "employee1"
    employee.Name ="Charles"; 
  }
  -------------------------------------------------------

  Static variable - it seems like in this case we set a variable to a string or val that shouldn't change between other instance of the class
  -------------------------------------------------------
  class Employee{
    public static string Name {get; set;}
  }
  private void Form1_Load(object sender, EventArgs e){
    Employee.Name ="Charles";// we don't have to make an isntance of the class  but can instead jsut call the class if it's static
  }
  -------------------------------------------------------

**METHOD**

    Non-static Method
  -------------------------------------------------------
  class Employee{
    public string change_name(){
        return "George";
    }
  }
  private void Form1_Load(object sender, EventArgs e){
    Employee employee1 = new Employee();//Makeing an instance of a class Employee named "employee1"
    employee.change_name(); 
  }
  -------------------------------------------------------



    Static Method
  -------------------------------------------------------
  class Employee{
    public statoc string change_name(){
        return "George";
    }
  }
  private void Form1_Load(object sender, EventArgs e){
    Employee.change_name();
  }
  -------------------------------------------------------


  **CONSTRUCTOR**

2 types of constructors:
- isntance 
- static


1. instance constructor
    - used to initialize instance data 
    - instance constructor is called everytime 
      when a class obj is created 
      it is called explicitly 
    - instance constructor take parameters 
    - it has access modifier/specifier 


2. Static constructor
    - is used to initialize static data or perform a particular action
      that needs to be preformed only once in the life cyle of a class
    - it is the first block of code to execute in a class 
    - executes one and only one time in the life cyle of a class 
      and is called automatically 
    - it takes no parameters 
    - it has no access modifiers/specifiers
    - it is not called directly



   instance constructor
  -------------------------------------------------------
  class Employee{
    public Employee(){
    }
    public Employee(string text){
        MessageBox.Show(text);
    }
  }

  private void Form1+Load(object sender, EventArgs e){
        Employee employee1 = new Employee("Instance constructor");
  }
  -------------------------------------------------------



   static constructor
  -------------------------------------------------------
  class Employee{
    static Employee(){
        MessageBox.Show("static constructor");
    }
  }

  private void Form1+Load(object sender, EventArgs e){
        Employee employee1 = new Employee();
  }
  -------------------------------------------------------


**CLASS**



   static Class - you define a static class then all the elements inside the class must be defined as static
                  or else you will get an error
  -------------------------------------------------------
static class Employee{
    public static int ID{get; set;}
    public static string ChangeName(){
        return "Charles"
    }
}

private void Form1_Load(object sender, EventArgs e){
    Employee.ID =2;
    string name = Employee.ChangeName();
}
  -------------------------------------------------------


  


