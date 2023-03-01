directory and directory info



Directory Class  |  Directoryinfo Class | Use
(static Methods) |                      |
-------------------------------------------------------------------------------------
CreateDirectory    Create                 Create a directory.
Delete             Delete                 Delete a directory.
Exist              Exist(property)        Check whether a directory exists
                                          Note: the directory class implements
                                          a method exist while the DirectoryInfo 
                                          class implements exists as a property.
Move               MoveTo                 Move a directory to the destination path.
GetDirectories     GetDirectories         Get subdirectories within a directory.
GetFiles           GetFiles               Get files within a directory.
GetDirectoryRoot   Root(property)         Get the root of a directory.
                                          Note: DirectoryInfo class imlplements root
                                          as a property.
GetLogicalDrives                          Get the logical drives availale.
                                          Note: there is no corresponding DirectoryInfo class
                                          member.
GetParent           Parent(property)      Get the parent directory.
                                          Note: DirectoryInfo class inplements parent as a property.
-------------------------------------------------------------------------------------------



Using Directory Methods
*if you create a folder without a path
 the folder will be created in **bin debug**
 in the project folder
**example below has no path!**
---------------------------------------------
//declaring directory class with name "newfolder" i think
Directory.CreateDirectory(@"newfolder");

//instantiating a directory from the directory class we made above
DirectoryInfo directory1 = new DirectoryInfo(@"newfolder");
directory1.Create

----------------------------------------------


Declaring directory class with specified directory path!
---------------------------------------------
//declaring directory class with a directory path
Directory.CreateDirectory(@"C:\newfolder\temp");

----------------------------------------------




DirectoryInfo - properties and methods

Attributes    - used to get or seth attributes for the current file or directory

CreationTime  - used to get or set the creation time of the current file or directory

CreationTimeUtc - used to get or set creation time, in cooredinated universal time (UTC)

Exists - used to get a value indicating whether the firectory exists.

Extension - it is used to get the string representing the extension part of the file.

FullName - it is used to get the full path of the directory.

LastAccessTime - it is used to get or set the time the current file or directory was last
                 accessed.

