Sorting and grouping data

Restrict and sorting data

**Distinct** - lets you get only uniqure records

**Distint Syntax**
--------------------------------------------------
Select Distinct col1, col2, co3 From tableName
---------------------------------------------------

**Distinct Syntax**
--------------------------------------------------
Use AdventureWorks2019
Go

Select DISTINCT firstName from Person.Person
--------------------------------------------------


**TOP syntax** - used to specified the top x number of rows to return
--------------------------------------------------
Select TOP number col1, col2, col3 From tableName
--------------------------------------------------



**TOP example** - gets top 20 rows from all rows in person table
--------------------------------------------------
Use AdventureWorks2019
Go

Select Top 20  * from Person.Person
--------------------------------------------------




**ORDER BY** - sorts in a type of order.- Alphabetically organizes
---------------------------------------------------
Use AdventureWorks2019
Go

--ASC is used to sort things in ascending order (it is also default)
Select FirstName, MiddleName, LastName 
From Person.Person Order By FirstName ASC
---------------------------------------------------


**ORDER BY** - using DESC (descending order)
---------------------------------------------------
Use AdventureWorks2019
Go


--DESC is used to sort by descending order (from the bottom to the top; from Z to A)
Select FirstName, MiddleName, LastName 
From Person.Person Order By FirstName DESC
---------------------------------------------------


**GROUP BY syntax** - used to arrange data into groups
---------------------------------------------------
Select column1, conlumn2, column3 From tableName
Where Condition
Group By column1, column2, column3
Order By column1, column2, column3
---------------------------------------------------


**GROUP BY Example** - used to arrange data into groups
---------------------------------------------------
Use AdventureWorks2019
Go


Select Shelf, sum(Quantity) as 'Total Quantity' 
from Production.ProductInventory 
Group By Shelf
Order By Shelf -- fromt largest to smallest
---------------------------------------------------


**HAVING syntax** specifies conditions that filter whichc group results apppear in the final results
---------------------------------------------------
Select column1, conlumn2, column3 From tableName
Where Condition
Group By column1, column2, column3
HAVING Condition
Order By column1, column2, column3
---------------------------------------------------




**HAVING** must come after group by clause
---------------------------------------------------
Use AdventureWorks2019
Go

Select Shelf, sum(Quantity) As Quantity, sum (Bin) as Bin
from Production.ProductInventory
Group By Shelf  HAVING Shelf = 'C' Order By Shelf
---------------------------------------------------