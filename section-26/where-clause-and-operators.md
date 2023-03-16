Where clause and operators

Retriving all data
- may cause speed problems.

- better way is to just get specific rows
- this is where the "Where" clause comes in!


**Where Cluase Syntax**
- used to speficy a condition while fetching data
  from a single table or by joining with multiple tables

- if the given condition is satisfied then it only returns a specific value from 
  the table
---------------------------------------------------
Select col1, col2, col3
From tableName
Where CONDITION
---------------------------------------------------



**Where Example**
- you indicate which columun then a name/val in that column and it returns all rows with that
  specified name/val
- if there is 2 of that name/val then only 2 rows show up, 1 if 1 and none if none
---------------------------------------------------
Use AdventureWorks2019
Go

Select * from Person.Person
Where FirstName = 'Terri'
---------------------------------------------------



**SQL Operators**
- its a reserved word or charcter used primarily in SQL
   statements' where clase to perform certain 
   comparisons and math operations.

- comparison operatios
= equal to
> greater than
< less than
>= greater than or qual too
<= less than or equal to 
<> not equal


**SQL LOGICAL OPERATORS**
- logical operators
AND  - TRUE if all the conditions seperated by AND are TRUE
OR - TRUE if either of the conditons speareted by OR is TRUE
BETWEEN - TRUE if the operand is wihtin the range of comparisons
IN - TRUE if the operand is equal to one of a list of expressions
EXIST - TRUE if the subquery returns one or more recrods.





**AND example** - more specific
---------------------------------------------------
Use AdventureWorks2019
Go

Select * from Person.Person
Where FirstName = 'Dylan' AND LastName = 'Miller'
---------------------------------------------------




**OR example** - less specififc; more broad
---------------------------------------------------
Use AdventureWorks2019
Go

Select * from Person.Person
Where FirstName = 'Dylan' OR LastName = 'Miller'
---------------------------------------------------



**BETWEEN AND example**
---------------------------------------------------
Use AdventureWorks2019
Go

Select * from Person.Person
Where BusinessEntityID BETWEEN 1 AND 8
---------------------------------------------------


**IN example**
-- gets exact rows listed in the "()"
---------------------------------------------------
Use AdventureWorks2019
Go

Select * from Person.Person
Where BusinessEntityID IN (1, 7, 10, 12)
---------------------------------------------------