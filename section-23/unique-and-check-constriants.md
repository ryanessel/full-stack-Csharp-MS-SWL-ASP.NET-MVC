Unique Constraint - 
- Ensures that all values in a column are different
- prevent two records from having identical vals in a
  particular column

  - LIMITS DUPES

Create Table tableEmployees(
    EmployeeID int primary key Not Null,
    EmployeeName varchar(50) Not Null,
    Phone int Not Null Unique,
    DepID int Not Null
)



Check Constraint - enssures that all vals in a 
                   column satisfy certain conditions
                 - enables a condition to check that val
                   being entered into a record.
                 - if the condition evaluates as false
                   the record violates the constraint and it won't
                   be entered into the table


Example check constraint
// be below checks if the person is 18 or older (working age???)
--------------------------------------------------------------
Create Table tableEmployeesB(
    EmployeeID int primary key Not Null,
    EmployeeName varchar(50) Not Null,
    Phone int Not Null,
    Age int Not Null Check (Age >= 18),
    DepID int Not Null
)


--------------------------------------------------------------

Adding constraints after the table has been made
* remeber to highlight and only execute the code you need too or else you will cause 
  problems or get an error.

Alter Table tableEmployeesB
Add Constraint CHK_EmployeeAge
CHECK(age >=18)



Deleting constriants

Alter Table tableEmployeesB
Drop Constraint CHK_EmployeeAge