Class and Object

- Classes are most important component  of OOP
  because they allow us to make objs in C#
- also reduces the complexity of the program
  since everything is encapped in classed
- use a class many times
- both functions and data are linked at the same tim
- must contain a number of members for the objects to
  be created in it

CLASS - properties (memebers?)
- Fields
- Methods
- Constructors
- Properties
- Events 
- Delegates

**serves as a template for objs**
- class difines the operations and properties 
  associated with the states of the objs

- data and procedures for objs with common properties
  are collected into a class 

- **objs are defined in the program using this class
  structure**

- generally a class declaration contains only a keyword class
  followed by a name of the class
- but there are optional attributes which can be used with the class 
  declarations according to the appplication requirements
- a class is a user defined blueprint or prototype from which objs
  can be made 
**class combines fields and methods into a single unit!!!**

- in C# classes support the ploymorphism inheritence and also provide
  the concept of dirived classes (extended class if JS) and base classes 


class Employee
{

}




- classes are the template and objs are the product made from that template
- In OOP objects are generated from classes
- unlike classes objs are alive and have identities
- properties of two objs of the same class are similar but these properties
  may vary 

**RELATIONSHIP OF CLASS AND OBJ BELOW:**

----------------------------------------------------------------
// creating an obj from the class "Employee"
Employee personalDetail = new Employee(); // "personalDetail" can be anything


----------------------------------------------------------------

--Class Concepts--
Namespace - categorizes the class. so you could have multiple classes
in one namespace(library)
- is keyword that defines a distinct name or last name for the class
  It categorizes an organizes a library where the class belongs and
  avoids collisions with classes that share the same name


Class Declaration
- is a line of code where the class name and type are defined 
  


Fields 
- fields are a set of variables declared in a class block


Constant
- are set of cosntants declared in a class block and MUST be defined with a 
  value because later you can change these values


Constructors 
- are methods or a group of methods that contain code to initialize the class.
  Constructors will be executed first 
  


Properties
- are the set of descriptive data of an object 


Events
- are program responses that get fired after a user or application aciton


Methods
- are a set of functions of the class 


Destructors
- is a method that's called when the class is destroyed.
  In managed the garbage collector is in charge of destroying objects.
  However, in some cases developers need to take extra actions when 
  objects are being released.
  Such as freeing handles or deallocating unmanaged objs.
  In .NET there is no concept of deterministic destructors.
  The garbage collector will call the finialize method at a non determinisitc
  time. While reclaiming memory for the application.


CLASS CONCPET EXAMPLE CODE

----------------------------------------------------------------
namespace ClassConcepts{ *// namespace*
    public class MathOperations{*// public is an acces modifier*
        const double pi =3.14; *// constant variable*
        string operationName; *// operationName is a field*
        MathOperations(){} // *class name*
            double operation(double parameter){*//operation is a method*
                double result =0; **// ↑ is a property; params are properties in a Class**
                return result;
        }
        double parameter {get;set;} // *setting and retreiving values*
    }


}

----------------------------------------------------------------

**Access Modifer Important Note**
- they are called **access** modiferies
  because they modify the accesibiity of the
  thing they are targeting