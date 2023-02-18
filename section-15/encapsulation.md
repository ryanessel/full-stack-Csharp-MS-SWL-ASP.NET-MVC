Encapsulation
- Is an OOP basic concept which means:
- protect important data inside the class which we don't want 
  exposed outside of the class
- process that binds the data memebers 
  member funcitons into a single unit
- Class is one of the best examples of encapusulation

- why is it needed?
- encapsulation complements abstraction:
  meaning encap hides privte or unwanted data
  from outside the class

- abstraction displays only the important features
  of a class.
- using encap we can make variables, props and methods 
  private so that it is not accesable to all but
  accesable through the proper channels
  the purpose is to protect it from accidential corruption from
  other classes.


Encap and Access Modifiers (AM)
- there are 6 access modifies
  1. Private - only accessable in the class in which it was defined; least permissive access level
  2. Public - accessable anywhere; most common access specifier in C#
  3. Protected - is useful when you want your class and all derived child classes to be able to access a method or variable 
                 but you don't want it to be public
  4. Internal - hides memeber variables and methods from other classes and objs that resides in 
                other name spaces - vars or classes that are declared with internal can be accessed by any member within an app.
                Internal is the default access specifier for a Class in C#

  5. Protected internal - is a combinaiton of protected and internal; we can access the protected internal memember only in the same
                          assembly or a derrived class in other projects. 
  6. Private Protected (from C# 7.2) - is combo of private and protected access modifieers; we can access memebers in side the 
                                       contianing class or in a class that derives from a containing class but,
                                       only in the same project.
                                     - so if we try to access it from another assembly we will get an error 


What AMs will be used in this course?
- public
- private
- protected

In multi layer architechture 
- use others

Methods for Encap
- get and set

Look at the C# .NET framework project for examples