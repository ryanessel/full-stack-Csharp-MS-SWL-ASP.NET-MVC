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
