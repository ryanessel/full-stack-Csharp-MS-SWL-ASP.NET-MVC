Wild Card Operations - used to search for data within a table

LIKE operator is used in thwe WHERE clause of the following statements:
- select
- update
- delete 

Wildcards used in conjunction with:
- percent sign(%)
- underscore (_)

**LIKE CLAUSE (%)** - used to compare a value to similar calues using wildcard operators
------------------------------------------------
Select column1, comlumn2, column3, From tableName
Where COLUMN LIKE Clause
------------------------------------------------


**LIKE CLAUSE (%) example** - 
------------------------------------------------
Select column1, comlumn2, column3, From tableName
Where COLUMN LIKE 'a%' -- finds any vals that start with the letter "a"
------------------------------------------------



**LIKE CLAUSE (%) example** - gets all rows of people who's first name starts with "r"
'x%' - all starting with x
'%x' - all ending with x
------------------------------------------------
Use AdventureWorks2019
Go

Select * from Person.Person
Where FirstName Like 'r%' -- gets all rows where the first letter of the FirstName Column is r
------------------------------------------------



**LIKE CLAUSE Last letters**
------------------------------------------------
Use AdventureWorks2019
Go

Select * from Person.Person
Where FirstName Like '%er' gets all rows where the first letter of the FirstName Column is er
------------------------------------------------