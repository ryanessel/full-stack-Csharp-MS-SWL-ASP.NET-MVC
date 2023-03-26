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
'%x%' - gets any values that containt at least one letter 'a'
------------------------------------------------
Use AdventureWorks2019
Go

Select * from Person.Person
Where FirstName Like 'r%' -- gets all rows where the first letter of the FirstName Column is r
------------------------------------------------



**LIKE CLAUSE Last letters**
'%x' - all ending with x
------------------------------------------------
Use AdventureWorks2019
Go

Select * from Person.Person
Where FirstName Like '%er' gets all rows where the first letter of the FirstName Column is er
------------------------------------------------



**LIKE CLAUSE any letters that are containt in a set in any position**
'%x%' - gets any values that containt at least one letter 'a'
------------------------------------------------
Use AdventureWorks2019
Go


Select * from Person.Person
Where FirstName Like '%er%' 
------------------------------------------------




**LIKE CLAUSE (_)**
-------------------------------------------------
Select col1, col2, col3 Form tableName
Where COLUMN LIKE '_inda'
-------------------------------------------------



**LIKE CLAUSE (_)** - gets a only a spefic length of strings. including the "_" so '_oger' will get only 5 letter words with '_' allowed to be anything.
- you can even just used multipel "_" to limit the length of the string you want to have serarched
-------------------------------------------------
Use AdventureWorks2019
Go


Select * from Person.Person
Where FirstName Like '_oger' 
-------------------------------------------------


**LIKE CLAUSE (_)** - you can configure this _ however you like and put as many or as little as you like and intersperse letters between the _  like below:
-------------------------------------------------
Use AdventureWorks2019
Go

Select * from Person.Person
Where FirstName Like 'D_v__' 
-------------------------------------------------

**LIKE CLAUSE** - Syntax used to represent any single character within a short list
-------------------------------------------------
-- finds any val that starts with either, x, y or z.
Select col1, col2, col3 From tableName
Where colName LIKE '[xyz]%'
-------------------------------------------------



**LIKE CLAUSE** - proper example used to represent any single character within a short list
-------------------------------------------------
Use AdventureWorks2019
Go
-- finds first names starting with letter  'a', 'b', or 'c'
Select * from Person.Person
Where FirstName Like '[abc]%' 
-------------------------------------------------



**LIKE CLAUSE** - method that gets first names with letters from a to h. the - represent everything inbetween the 2 numbers it is sperarting.
-------------------------------------------------
Use AdventureWorks2019
Go
-- finds first names starting with letter  'a', 'b', or 'c'
Select * from Person.Person
Where FirstName Like '[a-h]%' 
-------------------------------------------------


**NOT LIKE CLAUSE** - excepts the information inside the brackets; everything but the info in the brackets
-------------------------------------------------
Use AdventureWorks2019
Go
'
Select * from Person.Person
Where FirstName Not Like '[a-h]%' 
-------------------------------------------------


**NOT LIKE CLAUSE** *i add order by so we can see it in alphabetical order and so we can see that the "not like" thing is working
-------------------------------------------------
Use AdventureWorks2019
Go
-- gets everything but the first names sstarting with "a" 
Select * from Person.Person
Where FirstName Not Like '%a%' 
Order by FirstName
-------------------------------------------------