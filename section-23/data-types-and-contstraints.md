data-type-and-constraints

SQL data type is an attribure that specified the type of data of any object
- each column, variable and expression has a related data type on SQL
Data types

- int - for numbers
- Bit - used for true or false boolean operations? - checkbox (0 false/ 1 true)
- Decimal - 
- Datetime
- Char - can't set limit- limiit is 8000
- Varchar - used to specify strings - can speficy legnht like varchar(50)
- Binary - used to store bytes 


Constraints - rules encfoed on data columns on the table
              used to limit the type of data that can go 
              into a table. Ensures accurance realiablity
              of the data in the db.
              
- **Not Null Constraint** - ensure column cannot have a NULL value.

Example of making a table with "NOT NULL" - can't be blank
------------------------------------------------
Create Table tableEmployees(
    EmployeeID int primary key Not Null,
    EmployeeName varchar(50) Not Null,
    Phone int Not Null,
    DepID int Not Null
)
------------------------------------------------

- **Default Constraint** - provide a default val for a colmun  
                           when none is specified

Example Default Constraint
------------------------------------------------
Create Table tableEmployees(
EmployeeID int primary key Not Null,
EmployeeName varchar(50) Not Null,
Phone int Not Null,
DepID int Not Null,
Salary Decimal (10, 2) Default 3000.00
)
------------------------------------------------


- **Primary Key** - Uniquely identified each rows/records
                    in a database table.

- Primary keys must contrain unique vals
- cannont have null vals 
- if table has a primary key defined on any field, then 
  we cannont have two records having the same value.
  In other words, we have have diplicates in that same primary key column.
  if "1" exists you can't have another cell in that column with "1".


                    
Example Primary Key Constraint- no dupes!
------------------------------------------------
Create Table tableEmployees(
EmployeeID int PRIMARY KEY Not Null,
EmployeeName varchar(50) Not Null,
Phone int Not Null,
DepID Not Null
)
------------------------------------------------