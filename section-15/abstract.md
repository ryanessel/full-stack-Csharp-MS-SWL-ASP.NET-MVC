Abstract
- type of special class, can't be instantiated
- abstract class is designed to be inherited by subclasses
  that either impliment or override its methods 

- in other words, abstract classes are either partially
  implemented or not implemented at all

- methods in an abstract class can be both abstract 
  and concrete

- it can have constructors 
- You can take advantage of abstract classes so you can 
  design compnents and specify certain level of common
  funcitonality that must be implemented by derived classes.

- cannot create an instance of an abstract class 
- abstract class can inherit from a class and one ore more
  interfaces 

- can implement code with non-abstract methods

- abstract class can hae modifiers for methods, properties, constants, fields,
  constructors or destructors 
- abstract class can also implement a propert but, asbstract 
  classes cannot be inherted from structures.
  -cannont support multiple inheritences



  
Syntax - defining abstract class
- can add abstract methods as well as non-abstract methods
- 
---------------------------------------------------------
abstract class Vehicle{
    public abstract double getFuelAmount();
    public double getWeight(){
        double weight =3000;
        return weight
    }
}



---------------------------------------------------------




Exmaple of defining abstract class
- If we have abstract class in a base method
  we have to override this method in a derived class
--------------------------------------------------------
// defining abstract class
abstract class Vehicle {
    public abstract double getFuelAmount();
    public double getWeight(){
        double weight = 3000;
        return weight;
    }

}
// making inherited class Bus from Vehicle
class Bus:Vehicle{
    public override double getFuelAmount(){ // must override this abstract method
        return 300
    }
}

// making inherited class Bus from Vehicle
class Truck:Vehicle{
    public override double getFuelAmount(){// must override this abstract method
        return 500;
    }
}

--------------------------------------------------------


Visual Studio C# .NET FRAMWORK PROJ from here
