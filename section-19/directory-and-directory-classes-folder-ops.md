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



More methods...

LastAccessTimeUtc  -  used to get/set time in UTC that the current file or dir was last
                      accessed.

LastWriteTime -  it is used to get or set the time when the current file or directory was 
                 last written.

LastWriteTimeUtc - used to get or set time in UTC, when the current file or dir was last written

Name - used to get the name of this DirectoryInfo instance.

Parent - used to get the parent directory of specified subdirectory.

Root - used to get the root portion of the directory.


More methods of directoryinfo ...

Create() - used to create a directory.

Create(DirectorySecurity) - used to create a directory using a DirectorySecurity obj

CreateObjRef(Type) - it is used to create an obj that contains all the relevant info required 
                     to generate a proxy used to communicate wih a remote object

CreateSubdirectory(String) - used to create a dubdirectory or dubdirectories on the specified
                             path.

CreateSubdirectory(String, DirectorySecurity) - used to create a dubdirectory or subdirectories on 
                                                the specified path with specified security.

Delete()  - used to delete this DirectoryInfo if it is empty.

Delete(Boolean) - used to delete this instance of a DirectoryInfo, specifying whether to delete 
                  subdirs and files.



 Even more methods...

 EnumerateFile() - returns enumerable collection of dir info in the current dir

 GetAccessControl() - returns enumerable collection of the file info in the current 
                      directory.

GetDirectories() - returns the dubdirs of the current dir.

GetFile() - returns a file list form the currernt directory.

GetType() - used to get the type of the current instance.

MoveTo(String) - used to move a DirectoryInfo instance and its contents to a new path.

Refresh() - used to referesh the state of the obj.

SetAccessControl(DirectorySecurity) - used to set access control list (ACL) entries described by a 
                                      DirectorySecurity obj.

ToString()  - returs the og path that was passed by the user.

