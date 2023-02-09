Class and object in C#

Classes are most important thing of object oriented prgraming (oop)
this allows the program to be divided into parts; this reduces the complexity

methods and propertys are contained with in a class and can resuse a class 
in a class functions and data are closly linked 

class must contian a number of members for the objects to be created in.

Class serves as a template for objects operations and properties of the states of the objects

Class declaration contians only a keyword clap? followed by an an itedifer

User defined blueprint; combines fields and methods into a single unit.
Classes support polymorphism, inheritance provides concept of derrived classes as well as base classes. 

class  very basic syntax
-------------------------------------
class Employee
{

}
-------------------------------------

object - are the instances of the new class 
- alive an have identities
- two objects of the same class share similar structure but may vary
-------------------------------------
//employee is defined above then we create an instance below

Creating an instance of a class
----------------------------------------
Employee personalDtail = new Employee();
return EmployeeID
----------------------------------------

-------------------------------------

FIELD- must be declared in a type with a data type an an identifier
       that names the member
-------------------------------------
class Employee
{
    public int employeeID; // fields
    public string Name; // fields

}
-------------------------------------


Properties - are the special type of class memeber that provides a flexible mechanism 
             in order to read write or compute the value of a private field. Can be 
             used as if they are public data memebers but, there are actualy special methods called **acessors- enable data to be acessed easily and it helps to promote the flexibility and saftey of methods**

**※LOOK LIKE ANY OTHER VARIABLE DEFINED EXCEPT YOU SHOULD MAKE THE VARIABLE NAME CAPITAL**

**"get" and "set" are built in methods to help modify properties**


-------------------------------------
class Employee
{
    public int employeeID; // fields
    public string Name; // fields

    public int Age { // "Age" is a property - properties are Capitalized!
        get{ // help to modify the properties
            return Age;

        }
        set{// help to modify the properties 
            Age= value;
    
        }

    }

}
-------------------------------------


- GET AND SET METHODS- methods we use to acess properties
- get - gets you the data from the object
- set - assigns or "sets" values 


-------------------------------------
class Employee
{
    public int employeeID; // fields
    public string Name{
        get{


        }
        set{


        }

    }

    public int Age { // "Age" is a property - properties are Capitalized!
        get{ // help to modify the properties
            return Age;

        }
        set{// help to modify the properties 
            Age= value;
    
        }

    }

}
-------------------------------------

You can then use GET and SET as follows (though you don't explicetly invoke them):

--------------------------------------------------------------------------
// making new intance of class
Employee personaldetail = new Employee();

//assiging values with "set"
personaldetail.Name ="charles";
personaldetail.Age = 12;

//accessing values with "get"
string employeeName = personaldetail.Name;
int employeeAge = personaldetail.Age;



--------------------------------------------------------------------------

- Defining methods in classes - works similar to JS- we are already using methods
- when we are doing stuff like MessageBox.Show(); MessageBox is the object and "Show"
  is it's method (these are built in methods though)
--------------------------------------------------------------------------
public double FindSalary(int EmployeeID){
    double salary = 5000;
    return salary;
}
Employee personaldetail = new Employee();
double salary = personaldetail.FindSalary(32);

--------------------------------------------------------------------------