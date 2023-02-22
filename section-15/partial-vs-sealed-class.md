patrtial vs sealed class
- partial class 
    - special feature of C#
    - provides ability to implement the funcitonality of a single
      class into multiple files
    - then all these files are combined into a single class file 
    - when the application is complied.


**PARTIAL CLASS**

Partial Class is created using the keyword partial
- this keyword (partial) is usuful to split the functionality of methods,
  interfaces or structures into multiple files
------------------------------------------------------
public partial class Employee{
    public void method1(){
        
    }
}
--------------------------------------------------------






- partial modifer can only present instantly with keywords like
  struct, class and interface

------------------------------------------------------
public partial class Employee{
    public void method1(){
        
    }
}

public partial struct Employee2{
    public void method1(){

    }
}

public partial interface Employee3{}

--------------------------------------------------------




- every part of the partial class definition should be the same assembly
  and namespace but you can use different source file names
- every partial class name should have the same accessibility
  otherwise the complier will throw up an error 
--------------------------------------------------------
    public partial class Employee{
        public void method1(){

        }
    }
        public partial class Employee{
        public void method1(){
            
        }
    }
        public partial class Employee{
        public void method1(){
            
        }
    }

--------------------------------------------------------


- if anyt part of the partial class is declared as abstract
  sealed, or base the the whole class is declared as to be 
  that same type 
--------------------------------------------------------
    public abstract partial class Employee{// makes it so all partials are abstract
        public void method1(){

        }
    }
        public partial class Employee{// this and..
        public void method1(){
            
        }
    }
        public partial class Employee{//.. are abstract even though it isn't listed
        public void method1(){
            
        }
    }

--------------------------------------------------------

- the user is also allowed to use nested partial types 
- a dissimilar part may have dissimilar base types but,
- the final type must inherit all the base types 

Partial Class Advantages
- multiple devs can work sametime on the same class in different files
  - split the UI of the design code and the business logic code in order 
    to read and understand the code.
    -when working with automatically generated code the code can be added 
     to the class without having to reacreate the srouce file like in visual studio

- can maintain your applicaiton in an eficient manner by compressing large classes into 
  small ones.






**SEALED CLASS**
- used to restrict users from inherting the class 


Example syntax
- class can be sealed simply by using the keyword "sealed"

----------------------------------------------------------------------
public sealed class SealedClass{

}


----------------------------------------------------------------------


Example 2　 - of how sealed classs won't permit extending
- method can be sealed in that case it can't be overridden
- can be sealed in the classes in which they have been inherited 
  so if you DO want to declare a method as sealed then it has to be 
  declared as virtual in it's base class 
----------------------------------------------------------------------
public sealed class SealedClass{

}


//✕　attempting to extend the above sealed class will result in an error
public class NewClass:SealdClass{

}


----------------------------------------------------------------------

