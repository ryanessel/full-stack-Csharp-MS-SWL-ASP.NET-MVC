case function
- goes through conditions and returns a val when the first condition is met like an if then else statementas
- once a condition is true it will stop reading results


**CASE FUNCTION(STATEMENT) syntax**
--------------------------------------------------------------------------
Select col1, col2, col3
    CASE
        When condition1 THEN result1
        When condition2 THEN result2
        When condition3 THEN result3
    ELSE result
    END
From tableName
--------------------------------------------------------------------------


**CASE FUNCTION(STATEMENT) EXAMLPE**
--------------------------------------------------------------------------
Use Company2
Go

Select DepID, DepartmentName, 
-- adds new column with the strings or vals after 'then' if conditions are met
	Case
		When DepartmentName ='zipple' Then 'ZP'
		When DepartmentName ='gooter' Then 'GT'
		When DepartmentName ='nice' Then 'NE'
		-- end is needed to make it work.
		-- if you do as  then you can give then new column a name
		END as 'Abbriviations for Dep NAMES'
from tableDepartment
--------------------------------------------------------------------------




**CASE FUNCTION(STATEMENT) EXAMLPE** - using department name after "case"
--------------------------------------------------------------------------
Use Company2
Go

Select DepID, DepartmentName, 
-- putting column after 'Case' means wie can just type the conditon after when without havin to keep rewriting the column
	Case DepartmentName
		When 'zipple' Then 'ZP'
		When 'gooter' Then 'GT'
		When 'nice' Then 'NE'
		-- end is needed to make it work.
		-- if you do as  then you can give then new column a name
		END as 'Abbriviations for Dep NAMES'
from tableDepartment
--------------------------------------------------------------------------


**CASE FUNCTION(STATEMENT) EXAMLPE** - uusing ELSE
--------------------------------------------------------------------------
Use Company2
Go

Select DepID, DepartmentName, 
-- putting column after 'Case' means wie can just type the conditon after when without havin to keep rewriting the column
	Case DepartmentName
		When 'zipple' Then 'ZP'
		When 'gooter' Then 'GT'
		-- everthing else becomes 'NE' 
		Else 'NE' 
		-- end is needed to make it work.
		-- if you do as  then you can give then new column a name
		END as 'Abbriviations for Dep NAMES'
from tableDepartment
--------------------------------------------------------------------------