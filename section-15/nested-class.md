Nested-class
- its a class within a class 
- normally clases are declared within a namespace or in the default namespace if one
  is not specified.
- nested class is defined with in the code block of another class; its a class within a class
- this is to permit multiple nesting levels

- its the same as any other class
  -can be instantiated speratly to its parent class
  - it is not instantiated automatically by its its parent class
    つまり you can instantiate the parent but the nested class
          won't automatically be instantiated.

- key differnce is the scope of the class
- Nomrally, classes can be either public or internal but,
  nested class may be declared as "private"
  - this means the class can/is only be seen/accessible by its parent
    or other nested classes within that parent
- nested classes may be declared as protected 
  allowing it to also be accessed by classes that 
  derive from its parent type.
- this may be extended "protected internal" to allow other classes
  in the same assembly to access it.


Example - defining nested classes
- nested class can be declared as a private, public, protected,
  internal protected, or private protected 

------------------------------------------------
class OutClass{
    class InClass{

    }
}
------------------------------------------------





Example - outclass accessing inclass methods
- out class cannont access it's nested classes directly, because the inclass isn't instantiated
  automatically when the outclass is isntantiated.
- you can access in class methods to create objs of inner class in outer class like this
------------------------------------------------
class OutClass{
    public int outClassVar{get; set;}
    public void outClassMethod(){}
    public class InClass {
        public void inClassMethod(){}
    }

}
// you essentialy instantiated both classes at once
// in one object
OutClass.InClass obj = new OutClass.InClass();
obj.inClasMethod();
------------------------------------------------




Example - 
- looks like when you instantiate the InClass an obj of the outclass is also instatiated
- InClass can access non static memebers declared in the outer class
- 
--------------------------------------------------------
class OutClass {
    public static int outClassVariable{get; set;}
    public int nonstaticVar{get; set;}
    public void outClassMethod(){}
    
    public class InClass{
        public void inClassMethod(){
            OutClass obj = new OutClass();
            int nonstatic = obj.nonstaticVar;
        }
    }

}


---------------------------------------------------------

Example - Another example
- default access mofifier for the nested class(inclass) is private

---------------------------------------------------------
class OutClass {
    public static int outClassVariable{get; set;}
    public int nonstaticVar{get; set;}
    public void outClassMethod(){}
    
    public class InClass{
        public void inClassMethod(){
           int staticvar = OutClass.outClassVar;
        }
    }

}

---------------------------------------------------------



Example - 
- inherit a class into another class including nested classes
- the new class extends from the parent class

--------------------------------------------------------
class OutClass {
    public static int outClassVariable{get; set;}
    public int nonstaticVar{get; set;}
    public void outClassMethod(){}
    
    public class InClass{
        public void inClassMethod(){
            OutClass obj = new OutClass();
            int nonstatic = obj.nonstaticVar;
        }
    }

}

class NewClass : OutClass {
    public void newClassMethod(){}
}


---------------------------------------------------------