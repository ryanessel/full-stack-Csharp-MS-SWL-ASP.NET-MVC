create alter and drop database

**Ways to alter database name**
- Grpahically - just like how you do a folder; right click rename or somehting

- with a query
   - Alter database DatabaseName modify name = newDbName;


Exampple 
-----------------------------------------------
   

    Alter database TEST3 modify name = TEST




MAKEDB -- also can be done right cliking and "New database" on the "databases" folder
Create database TEST1


Delete DB - right click and delete also possible
Drop database TEST1

* can't drop or delete a db if it is currently in use
* in use means that it is accessible or usabale by other users.



-----------------------------------------------