What is c# oop?

OOP object oriented programing

- tries to fix this problem by
  creating networks of objects
  each like a small software
  machine

- these objects are naturally 
  smaller entities simplifing 
  the devlopment task of each unit

- when the obj cooperate in a system
  they become the building blocks of 
  a more complex solution


Analogy for OOP
-
car-
is a bunch of small machines/small bits of software
each parts is created seperatly, tested, then assembled to make
the car or program

Wheel has multiple key value pairs (has multiple properties)

Javascript obj example

※Something like this but you don't make objs like this in C#
-----------------------------------------------------
const wheel {

    tire: "rubber",
    rim: "alloy steel",
    brake: "racing breaks",
    breakePad: "brandNameHere,
    bolts: 6

}
-----------------------------------------------------

OOP is making things in to components and putting them in one
big program


**FAQ regarding C# OOP, MS SQL & ASP.NET MVC**
What is C#?
- general purpose OOP prgrm lange
- designed around 2k by Msft as part of
  it .NET initiative

- .NET framwork and .NET apps are multiplat
  apps that you can use with progrming lange
  suck as C++, C# and VB and COBOL.

- C# is open-source and as desinged to be simple
  yet, modern andlexible yet pwrfl and veristale
  yet east to learn and prgrm with

- C# was deved with usiness and enterprise
  needs in mind. By providing fuctionality 
  to support modern day sotftwre devment such as 
  web apps.



C# vs C++
- Due to .NET framwork C# it combines the power
  of C++ and VB. 
- C# has many new data types, saftey types
  to make usre you don't unknowling resue
  initialized variables. 
- Uses simplifed syntax, saves time comapred C++
  complex code
- C# removes memory management issues thanks to
  .NET's garbage colleciton scheme. 
- no need to reference items for garbage 
  collection; system can reclaim memory
  as required

Why use encapsulation in C#?
**Encap (Encapsulation)**
- encap can be used in c# to hide data and
  program behavior from users
- with encap you can group, props, methods,
  and other memebers so that they are treated
  as a single obj.
- encap hides how a program operates
  without affecting functionality while
  still allowing users to service requests
  for functinality and oadd or modify
  internal data or methods to meet changing 
  needs.
- For example, suppose you have an obj called 
  "Pateient" that contains pateint related data.
   Using encap you can hide patient-spefific data
   to those who need it without exposing all
   patient data. improves reusability

What is SQL and how is it used?
- SQL stands for structered query lanague.
- it is used to manage data in relational
  dbs(databases)
- allows one to query, manipulate and define data
  in a relation db.
- has become standard language, meaning that
  the lanaguage the  db uses will be based 
  on SQL despite which relation db you use.
- This make it a very versatile language and 
  important skill to have if you work with dbs
  or data. 
- the language clsoely resmbles English, making it
  easy for English speakers to  learn and read at
  a glance, even for a beginner.
- Statemes consist of clauses,idefities, operators
  and constants.
- together you can create statements such as 
**"SELECTcustomer_nameFROM Purchase_Table WHERE order_number = 253"**
- the satament above is readable by a computer and
  easiably understandable if you understand english

Jobs that use SQL
- many carrer paths benefits from knowing SQL
- Almost any industry hate uses data can benefit from
  someone that specializes in relation databases.
- some job specififcally focus on working with a database, such
  as Database Manager or Database Develper role.
- However, more and more jobs that do not soley concentrate on database
  maintenance require knowledge of SQL.
- Mostly all websites and applicaitons use a database, so various
  dev positions require knowlesge of SQL.
- Also, careers that involve working with data require
  skills in SQL.
- careers such as Data Scientist, Database Dev, DB admin, Business Analysts
  big data architecs

What is sql injection?
- common hacking technique
- it uses SQL commands to manipuate a db.
- it can happen wehn an app has been poorly deved and allows
  useser to isert info directly into a db.
- Example: if you ask a user to submit their name, a hacker can
  type an SQL command instead.
- If that command directly exxecutes against the db of the app an 
  injection attacked has a occured.
- for a db a command is a command and it cannot determine whether a command
  from a valid user or not. 
- because this is a common threat, it is easy to prevent.
- A golden rule of db management is to never input user data directly into
  the db.
- Many progamming languages with have a funciton that checks for SQL
  injections. So it is pretty easy to guard yourself against an SQL attack.

How long does it take to learn SQL?
- takes 2 weeks to a month to learn the basics if you are dedicated.
- however to be comfortable in non-trivial operations it takes a few montths
  to get your bearngs in SQL.
- Because SQL is so close to the English lanague it is not hard to read
  write and understand
- Reading SQL is only one aspect, it is more important to know how to 
  structure data and manage relationships between tables.

What is the best SQL cert?
- maybe any of them

What is best way to learn SQL?
- Practice.

What is a relation db?
- it is a type of db that stores data that is organized in structures
  called tables and these tables are related to oneanother though defined
  relationships.
- each table has columns and rows.
- columns represent attriburtes and define a structure to the data. 
- Each row is a record of info stroed in the table.
- The relationships between tables are defined by assiging certain columsn
  as foreign and primary keys.
- For example a vehicle table might contain the VIN number a a primary key
  since that uniquely identifies each record of information about a car. 
- there may be another table in the db called dealerships.
- The data can be structured in such a way that each car belongs to some 
  dealership.
- The realtipnship between these to tables can be organized by having 
  dealership's key in the vehicles table.

What are morst common forms of SQL and how do they differ?

- there are many forms of SQL, but postgreSQL, Microsfot SQL, and MySQL are 3 
  most widely used.
- each ofthese forms is an implimentation of SQL, their standards are set
  by different organizations.
- PostgreSQL and MySQL are both open source platforms mainatained by a
  wide community of devs while Mcsft devs Mcsft SQL.
-  an example, Microsoft SQL server uses GETDATE(), MySQL uses CURDATE(), and PostgreSQL uses CURRENT_DATE(). They also differ in languages supported; MySQL supports languages that PostgreSQL and Microsoft SQL don't, such as Haskell and Ruby. As Microsoft SQL is proprietary, it costs money to license

