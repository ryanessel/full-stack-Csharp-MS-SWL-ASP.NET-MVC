List Class
used to create a collection of different types like
-int
-string
-objects

Also provides methods to search  sort and maniupulate lists.

define lists like this
// list made of vars of specific types
List<int>numberList = new List<int>();
List<string>testList = new List <string>();

class Employee
{}
//object list made of class instance objs
List <Employee> EmployeeList = new List<Employee>();


**List is differnt from arrays**
- can be resized dynamically; arrays cannont be resized dynamically
- List class can accept null; arrays cannot accept null.
- allows duplicate elements
- if count becomes equal to capacity then the capacity of the
  List increases automatically by realocating the internal array
  exisitng elements will be copied to the new array before the addition of the new element 

  Ex: for an array you define an array like this int[] numbers = new int [4]; // 4 is the capacity 
  you would have to adjsut it manuall whereas with Lists it is updated automitcally


- List class is the generic equivelant of array list class by implimenting the list generic interface

- List class can use both equality and ordering comparer 
- List class is not sorted by default and elements are accesed by
  0 based index

- For large list objs we can increase the maximum capacity to 2 billion elems on a 64 system
  by setting the enabled attribute of the config of element to true in the runtime environt ment

------------------------------------------------------------------------------------------------


List Class Properties
- in C# (.NET) we usually use List for filling in a combo box, List box or DataGridView from a database
------------------------------------------------------------------------------------------------

We can access capacity count (???)

Example of properties
//setting up employee class with no properties
class Employee
{}

//seting up List named "EmployeeList" --- Employee class has to be defined above (can be whatever name you want)
// before List is defined; needs to have that obj class to target on to so it can make the list 
List<Employee>EmployeeList = new List <Employee>();

private void Form1_Load(object sender, EventArgs e)
{
    //making instance of employee class
    Employee employee1 = new Employee();
    Employee employee2 = new Employee();
    //Using the class List propertioes to add, remove Employee objs and remove and clear them as well
    EmployeeList.Add(employee1);// the .Add .Remove .Clear are some properties of List classes .Sort also 
    EmployeeList.Add(employee2);

    EmployeeList.Remove(employee1);
    EmployeeList.Clear();

}




Filling out DataGrid with DataSource List data!

------------------------------------
// dayslist is the DataGridView box, DataSource is the method(function) and the comboList is the listwhich has the data
dayslist.DataSource = comboList;

------------------------------------

