create-rename-delete(drop) tables

Working with tables

- Create Table
- Rename Table
- Delete Table
- Contraints
- Datatypes



2 tables
tableEmployees

4 columns
 - EmployeeID
 - EmployeeName
 - Phone
 - DepID - this column is referencing the tableDepartments DepID; has a relation
            (**foreign key**)



tableDEpartments
2 columns

 - DepID
 - DepartmentName


CREATING A TABLE
- GRAPHICALLY - USING THE APPLICAITON SQL SERVER MANAGAMENT STUDIO

- With a query
Syntax Example
----------------------------------
   Create Table TableName 
   (
        column1 datatype Primary Key Not Null,   ---- > if a field is choesn as a primary key it
                                                        should not be null ever
        column2 datatype,                                   
        column3 datatype


   )
----------------------------------


Proper Example 
-----------------------------------
Create table tableEmployees (
	EmployeeId int Primary key Not Null,
	EmployeeName varchar(50) Not Null,
	Phone int Not Null,
	DepID int Not Null
)
----------------------------------------------------------------------



Better Example, targets what db you want the table created in so even if SQL Management system has a different db selected it will only make it in the target db.
Use <DbName> - replace DbName including brackets
Go
----------------------------------------------------------------------
Use Company
Go

Create table tableEmployees (
	EmployeeId int Primary key Not Null,
	EmployeeName varchar(50) Not Null,
	Phone int Not Null,
	DepID int Not Null
)
----------------------------------------------------------------------


RENAMING A TABLE
- grpahically - using the SQL management system app 

- query

Example
------------------------------------------------------------------------

Use Company
Go

EXEC sp_rename 'tableEmployees','Employees'

------------------------------------------------------------------------



Dropping or deleting a table

- grpahically - using the SQL management system app; right clicking etc.
- query method
 

 Example
------------------------------------------------------------------------

Use DbName
Go

Drop table TableName

------------------------------------------------------------------------
