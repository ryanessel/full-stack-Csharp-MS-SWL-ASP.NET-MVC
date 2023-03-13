update data in a table

Update - used to update or modify the data in a table
2 ways
- graphically by right clicking - not reccomended for large data sets 
                                  only usable if table has just a few rows
                                  and won't change that frequently
                                  
- querying - 

SYNTAX
-------------------------------------
Update tableName
Set Column1 = NewValue,
    Column2 = NewValue2
Where


-------------------------------------




SYNTAX - updates the row so you could indicate any other column names to update vals and it would only change for that name
-------------------------------------
Update tableEmployees
Set EmployeeName= 'Frank'
Where EmployeeID = 1001 ----------------------> this probably must be a primary key 


-------------------------------------