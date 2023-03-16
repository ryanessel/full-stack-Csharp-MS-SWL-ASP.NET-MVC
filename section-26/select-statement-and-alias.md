select statement and alias

Retrieving Data
In SQL select statements are used to retrieve data from tables in a database


- Select
- order
- trim
- distrint
- math
- convert
- alias
- date 

All Columns

First statement to retrieve data

--------------------------------------
Select * From tableName --- remeber the "*" means all in cerding(coding)
- gets all columns from the table
- gets all data from the specififed table name.


--------------------------------------



- subqueries
- top 
- join 
- case 
- union
- like
- group by



getting only specififc columns and any combo thereof
columns will be listed in the order in whichc they are speficied

-----------------------------------------
Use Company
Go

Select EmployeeID, Age from tableEmployeesB;



------------------------------------------

**COLUMN**
**Alias** - lets us rename a table or column temporatily byt just giving it another name
----------------------------------------------------------------------
Use Company
Go          - column name    alias             tableName
          /                  /                   /
Select  EmployeeName AS HumanResourceTag from tableEmployeesB;
----------------------------------------------------------------------




**Using multiple aliases**
-----------------------------------------------------------------

Use Company
Go

Select  EmployeeName AS Name, Phone AS CELL from tableEmployeesB;
-----------------------------------------------------------------





**Alias using sapces**
---------------------------------------------------------------------------
Use Company
Go

Select  EmployeeName AS 'Worker Name', Phone AS CELL from tableEmployeesB;
---------------------------------------------------------------------------




* IMPORTANT: alais only valid in the sql query ithink
**Alias using spaces and differnt way of organizing code**
---------------------------------------------------------------------------
Use Company
Go

Select  
EmployeeName AS 'Worker Name', 
Phone AS CELL,
Age As 年齢
from tableEmployeesB;
---------------------------------------------------------------------------





**TABLE ALIAS** - renames a table for that query
---------------------------------------------------------------------------
Select col1, col2 From tableName AS aliasName



Example
- very weird... like i get it supposed to be so that you can give the table
                a different name so its shorter but the table listing doens
                seem to change doign this
Use Company
Go

Select 職員.EmployeeName, 職員.Phone, 職員.Age from tableEmployeesB as 職員
---------------------------------------------------------------------------


class Warrior{
constructor(hp, mp, atk, def, spd){

    this.hp = hp;
    this.mp = mp;
    this.atk = atk;
    this.def = def;
    this.spd = spd;
}
basicAttack(){
const dmgCalc= (range) => this.atk*(Math.ceil(Math.random()*range));    
let dmg =dmgCalc(6); 
console.log("dmg done is: ", dmg );
}

}