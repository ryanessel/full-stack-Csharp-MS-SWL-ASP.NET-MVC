Inheritance in C#
- allows us to define a class in terms of another app.
- makes it easier to maintain to create and maintain an app. 

- provides and opportunity to reuse the code funcitonality and speeds up implementation time.
   -when creating a class instead of writing completely new data memebers and memeber funcitons
    the programmer designate that the new class should inherit the memeber of an existing class 
   -the exisiting class is called the "base" class 
   -the new class is refered to as the derived class 
   -we could call this the first step of professional programming 

- In inheritance the most important point is finding the same properties in objects.


**Example situation of this use case**

School has these ojects - School would be the base class and each school has diferent values for their keys (or properties)
-OBJECTS-
-----------------------------
- board
- picture

- director
- table
- student

- bookcases
- teacher

↓ divide into 2 main class

Material-
- board
- picture
- table
- bookcases

Human -
Emmployee
- director 
- teacher
Student
- student

* like stated above the object will have the same property when derrived from the same class 
  only the vlaues of those propeties will change.

Inheritance is so we don't have to write the properties again.


Inheritance code set up example
-SYNTAX
--------------------------------------------------
access_modifier class BaseClassName
{
    //Base Class implementation
}

access_modifier class DerivedClassName: BaseClassName
{
    //Derived class implementation
}

--------------------------------------------------


Actual Example of Inheritance and derived class - Basically like javascript extends class
**single inheritance example**
--------------------------------------------------
class Human
{
    public char Gender{get;set;}
    public string name {get; set}
}

class Employee:Human // setting up derived class from Human called "Employee" it will still have Gender and name as keys/properties but will also now have Salary
{
    public double Salary {get; set;}
}

--------------------------------------------------

**4 Types of Inheritance**
- single inheritance
- hierarchical inheritance
- Multi-Level-Inheritance
- Multiple Inheritance


1. single inheritance
- type of inheritance where there is just one base class and one derived class



2. hierarchical inheritance
- type of inheritance in which there are multiple classes derived from one class



3. Multi-Level-Inheritance
- its when you make a derived class from an already derived class




4. Multiple Inheritance
- one class can have more than one super class and inherit features from all parent classes
**※C＃　does not HAVE or does not support multiple inheritance!!!※**
in C# we can only achieve multiple inheriutance only through interfaces.





ADVANATAGES AND DISADVANTAGES OF INHERITANCE

**Advantages**

- reduces code redundancy
- provides code reusability
- reduces source code size
- improves code readability 
- its divided into parent and child classes making it easy to manage.
- it supports code extensibility by overrriding the base class functionality within child clasees

**Disadvantages**
- base class and child classes are tightly coupled; if you change the code in the parent class it effects all of 
  the child classes 
- in class hierarchy many data memebers remain unsed and 
  then the memeory allocated to them is 
  not utilized ; bad for optimization 
- if you don't implement inheritance correct, it effects performance of yoru programl; optimization?





