exception handliing
- maintians the normal flow of the applicaiton; allows the rest of the code to run after an event exception

- handing a c# process to handle runtime erros
- we preform exception handling so that the normal flow. Of the web application can be maintianed even after runtime errors 

**exception**
- is an event or an obj which is thrown at runtime
- all exceptions are derived from the system exception class; this makes it handleable
- *not handling the exception causes the exception msg and the program is terminated/ stopped *

- maintians the normal flow of the applicaiton; 
  **allows the rest of the code to run after an event exception**

- exceptions allow app to transfer control from one part
  of the code to another.

- When exception is thrown, current flow of code is interrupted then,
  handed back to parent( a try catch block)- expection handling is done
  with these keywords.

**Key words for exception handling**
------------------------------------
- try 
- catch
- finally
- throw



1. try
- identifies a block of code for which a particular exception is activated
- then is followed by 1 or more catch blocks


2. catch
- catch except at the place in a program where you want to handle the problem.
- "catch" keyword indicates the cataching of an exception 



3. finally
- is used to execute a given set of statements, whether or not an exception is
  thrown.
- for example: if you open a file it must be closed whether an exception is raised
  or not.


4. throw
- throws an exception when a problem shows up and is down is "throw" keyword
------------------------------------


Exception Handnling examples
------------------------------------------------------------------
System.IO.IOException - handles I/O errors.
System.IndexOutOfRangeException - handles errors generated when a method refers to 
                                  an array index out of range.
System.ArrayTypeMismatchException - Handles errors generated when type is mismatched
                                    with the array type.
System.NullReferenceException - Handles errors generated from referencing a null obj
System.DivideByZeroException - Handles erros generated from dividing a divided with
                               zero.
System.InvalidCastException - handles errors generated during typecasting.
System.OutOfMemoryException - handles errors generated from insufficient free memory
System.StackOver - handles errors generated from stack overflow.




------------------------------------------------------------------

