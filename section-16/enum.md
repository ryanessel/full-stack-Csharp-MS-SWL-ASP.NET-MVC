Enum (Enumeration)
- is a value data type in c#
- used to assign names or string values to intergral constants
- set of named constants
- used to make code more readable by giving realted constants a meaingful name
- improves maintainabilityqqq


Enum example -
- declare liek below:
-----------------------------------------
enum colors{
    red,
    blue,
    white,
    black,
    yellow,
    purple,
    brown,
    orange
};
-----------------------------------------

All enum types derive from the system enum



- Enum can included named constants of numeric data types 
  int, double etc

**Enum cannont be used with STRING TYPE**

Enum example 
------------------------------------------
int enumOrder = (int) colors.blue


------------------------------------------





Enum example 
- enums have a value atuomatically assigned starting from 0 for the first elem in the list
- if you give an element a number the next elem in the list will be that previous number +1
  see below
------------------------------------------
enum colors{
    red = 5,
    blue,  // ---------> 6
    white,// ---------> 7
    black,// ---------> 8 etc.
    yellow,
    purple,
    brown,
    orange
};

------------------------------------------

Enum example
- it will always start from zero but anywhere you give it a new value all
  elemes after that one will be that number plus one
- see below:
------------------------------------------
enum colors{
    red, // 0
    blue,  // 1
    white = 6,
    black, // ---------> 7
    yellow, // ---------> 8 and so on
    purple,
    brown,
    orange
};

------------------------------------------



**Enum Methods**

1. Format - converts the specififed value of enum type to the specififed string format.
2. GetName - returns the name of the constant of the specified value of specified enum.
3. GetNames - returns array of string name of all the constants of specefied enum.
4. GetValues - returns an array of values of all the constants of specified enum.
5. object Parse(type string) - converts the string representation of the name or numeric
                               value of one or more enumerated constants to an equivalent
                               enumerated object(s)
6. bool tryParse(string, out TEnum) - converts the string representation of the name or 
                                      numeric value of one or more enumerated constants
                                      to an equivalent enumerated object. The return
                                      value indicates whether the conversion succeeded


Examples

- GetName()

-----------------------------------------
enum colors{
    red,
    blue,
    white,
    black,
    yellow,
    purple,
    brown,
    orange
};

string namevalue = Enum.GetName(typeof(colors), 4) // it should be "yellow" that is returned
                                                   // because that number is an index number


-----------------------------------------