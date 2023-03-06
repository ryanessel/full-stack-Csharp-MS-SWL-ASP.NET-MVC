Normalization

1NF- set the very basic rules for an organized database 
- the table should have the following rulles
  - the data in each column should only have an atomic (single value); can;t have multiple phonme numbers in the same row.
  - all columns in a table should have unique names


  Without 1NF the following bad things will happen:
   - difficult to handle spefific data in the followning ways:
    - inertion
    - deletion
    - updationg
    - this make the possibility of data loss high when doing these things above



2NF - 
 - will have all the rules of the 1NF
 - each set of related data should be stored in a separate table; related data should not be in the same table; seems like common sense.

 If you have a table and it has something like Phone column and a deptPhone column, these would be 2 different datagroups (this would not be a 2nd normal form)

 this table should be sperated into 2 differnt tables whichc will include related group info.
 it could be linked by both tables have the shared DepID columnes


  - Without 2NF - very effective on disk space efficiency and performance of the database.
   - it will cause repetition of data which cases disk space waste
   - unnescessary data making retrival of the data painfully slow.
3NF
 - will have all the rules of the 2nd normal form.
 - table shouldn't contian columns that are not fully dependant on primary a primary key
 

EmployeeID is the PRIMARY KEY HERE                not nessecary to be shown in this table because oemployee id and eduid
                                                  /
**EmployeeID** | EmployeeName | Phone | EduID | EducationName
-----------------------------------------------------------
1001              eric          444256    2     First  Aid
1002              tim           443455    1     Job safetey
1003              sam           774255    2     First  Aid
1004              nick          114255    2     First  Aid

- to make this first the 3NF we have to make the education name column show up in a different table 



 

 

  


