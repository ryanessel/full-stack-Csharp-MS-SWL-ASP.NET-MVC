Insert data into a table

insert
update
delete


how to install and set up adventure works db

**Insert With a Query**  **WITH COLUMNS!!!!**
-------------------------------------------
Insert Into tableName(
    Columns1, Column2, Column3
) values (val1, val2, val3)

-------------------------------------------

these all the numbers of vales you speficy must be equaly to the number of columns and in the same order

string value MUST be written between singe quote ('');


insert example real
--------------------------------------------

Use Company2
Go

Insert into tableEmployees
(EmployeeId, EmployeeName, Phone, DepID)
Values
(1005, 'Steve', 235008, 1)

----------------------------------------------



**Insert With a Query**  **WITH OUT COLUMNS!!!!**

can only do this if you insert values for all the columns in the table.
or else do the method above.
also values have to be in the same order as the columns
--------------------------------------------------------------
Insert into tableEmployees
Values(1006, 'PeterB', 412, 1)



--------------------------------------------------------------