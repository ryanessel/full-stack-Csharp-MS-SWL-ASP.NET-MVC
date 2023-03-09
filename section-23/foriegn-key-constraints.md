foreign key constraints

Foriegn Key (aka- Referencing Key)- uniquely identifies a row or record in any other
              databale table (think populate like javascript, lets you get data 
              from another table )
              - a key that is suedto link 2 tables together.
              - a column or comob of colums whose val match a primary
                key in a different table


              - means we have a connection or relation between these two tables
                with a this foreign key.
                Helps with sub querys 

Example Foreign Key Setup
------------------------------------------------------
// making one table

Create Table tableEmployeesA(
    EmployeeID int primary key Not Null,
    EmployeeName varchar(50) Not Null,
    Phone int Not Null,
    DepID int FOREIGN KEY references
    tableDepartments(DepID) Not Null,
)

// Making another table
// only the table above will be able to get the data from this table
// this table has a key which the first table is referenceing
// but makes no references it self.
// however the vals of the Key and foreign key reference MUST MATCH
// must make the table to be referenced first!

Create Table tableDepartmentA( 
    DepID int primary key Not Null,
    DepartmentName varchar(50) Not Null
)

------------------------------------------------------

