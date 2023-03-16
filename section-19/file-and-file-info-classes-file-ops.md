File and fileinfo classes

- using System.IO; // importing/using it

isntansiating it 
- System.IO.Stream stream = new System.IO.MemoryStream();


- these classes are used for file operations



C# includes:
- standard IO
- write
- input 
- output classes
- purpose is to read and write from different sources 

STREAM
- provide standard methods to transfer bytes like read and write to the source. 
- liek a wrapper class to transfer bytes 
- **so classes that need to read and write bytes from a particular soruce** must implement the stream class


**Stream Class inherits** - they provide funcitonality to read and write bytes from the stream class
                            which will provide funcitonality to the read write bytes from a particular
                            source.

- File Stream
- Memory Stream
- Buffered Stream
- NetWork Stream
- Pipe Stream 
- Crypto Stream 




- File Stream **※We will use file stream in this course ※**
 - reads or writes bytes from or to a physical file, whether it's text exe, jpeg, or any other
   file type file stream is derived from the stream class 


- Memory Stream
 - reads and writes bytes that are stored in the memory 


- Buffered Stream
 - reads or writes bytes from other streams to improve the performace of certain IO operations


- NetWork Stream
 - reads or writes bytes from a network socket, pipe stream 


- Pipe Stream 
 - reads or writes bytes from different processes.


- Crypto Stream 
 - is for linking data streams to cryptographic transformations, 
   



**READER AND WRITER CLASSES** - purpose to transfer bytes

- Stream Reader
- Stream Writer 
- Binary Reader
- Binary Writer 



- Stream Reader
 - helper class for reading characters from a stream by converting bytes into characters
   using an encoded value.
   Can be used to read strings or characters from different streams like file stream, memory stream
   etc.


- Stream Writer 
  -helper class for writing a string to a stream by covnerting characters into
   into bytes and that can be used to write strings to different streams such as file,
   stream, memeory stream. 


- Binary Reader
 - is a helper class for reading primitive data types from bytes



- Binary Writer 
 - writes primitive types in binary.




 **File & Fileinfo classes**

*File classes*

 AppenedAllLines - Appends lines to a file, and then closes the file.
                   If the specified file does not exist, this method
                   creates a file, writes the specified file.

AppendAllText - Opens a file, appends the specified string to the file, 
                and then closes the file. If the file does not exis, 
                this method creates a file.

AppendText - Creates a StreamWriter that appends UTF-8 endcoded text to an existing file, 
             or to a new file if the specified file does not exist.

Copy - Copies an existing file to a new file. Overwriting a file
       of the same name is not allowed.

Create - Creates or overwrits a file in the specified path.
CreatText - Creates or opens a file in the specified path.
Decrypt - Decrypts a file that was encrypted by the current account using the encrypte method.
Delete - Deletes the specified file.
Encrypt - Encrypes a file so only the account used to encrypt the file can decrypt it.
Exist - Determines whether the specified file exists.
GetAccessControl - Gets a FileSecurity obj that encaps the access control list (ACL) entries
                   for a specified file.


※Not really reccomended to use a file class for multiple operations on a multiple files 
*File Methods*
Move - moves a specified file to a new location, providing the opetion to specifity a new file name.
Open - opens a FileStream on the specified path with read/write access

ReadAllBytes - opens a bianary file, reads the contents of the file into a byte array, then cloes the file
ReadAllLines - opens a text file reads all lines of the file then closes the file.

Replace - Replaces the contents of a specified file with the contents of another file, 
          deleting the original file, and creating a backup of the file
WriteAllBytes - creates al new file, writes a collection fo strings to the file then closes the file.
WriteAllText - creates a new file writes the specified string to the file then closes the file.
               If the target file already exists, it is overwritten.


*FileInfo classes*

Directory - Gets an instance of the parent directory.
DirectoryName - Gets a string representing the directory's full path.
Exists - Gets a valeu indicating whether a file exists.
Extension - Gets the string representing the extension part of the file.
FullName - Gets the full path of directory or file.
IsReadOnly - Gets or sets a value that determines if the current file is read only.
LastAccessTime - Gets or sets teh time the current file ro directory was last accessed.
LastWriteTime - Gets or sets the time when the current file or directory was last accessed.
Length - gets the size, in bytesm of the current file.
Name - gets the name of the file

*FileInfo Methods*
AppendText - creats a StreamWriter that appends text to the file represented by this instance of the FileInfo.
CopyTo - copies an existing file to a new file, disallowing the overwriting of an existing file.
Create - Creates a file.
CreatText - creates a StreamWriter that writes a new text file.
Decrypt - Decrypts a file that was encrypted by the current account using the encrypt methid,
Delete - Deletes the specified file.
Encrypt - Encrypts a file so that only the account used to encrypt the file can decrypt it.
GetAccessControl - Gets a FileSecurity obj that encps the access control list (ACL) entries for a specified file.
****MoveTo - Moves a specified file to a new locaitonm propviding the option to specified a new file name.

Open - opens a FileStream in the specified FileMode.
OpenRead - Creates read-only FileStream
OpenText - creats a StreamREader with UTF-8 encoding that reads from an existing text file.
OpenWrite - create a write only FileStream.
Replace - replaces teh contents of a specified file with the file described by the current FileInfo obj,
          deleting the og file and greating backup of the replaced file.
ToString - returns a path as string.





		private void btnCreate_Click(object sender, EventArgs e)
		{
			// simple creates a file in the Bin/Debug folder of the project if you don't specify
			File.Create("test-file-1");
		}


FILE INFO vERSION OF THIS

			FileInfo ourfile = new FileInfo("test-file-2.txt");

			ourfile.Create();




BUTTON THAT DELETES THE SPEFICIC FILE NAME

		private void btnDelFirstFile_Click(object sender, EventArgs e)
		{
			// the text in side the quotation marks must be exact! evne down to the file extension.
			File.Delete("test-file-1.txt");
		}


BUTTON DEMOSTRATING FILE STREAM AND STREAM WRITER!
Lets you create a file and also add text to the file - pretty wild 

		private void btnWrite_Click(object sender, EventArgs e)
		{
			// sets up file stream
			FileStream fs1 = new FileStream("third.txt", FileMode.OpenOrCreate, FileAccess.Write);
			//lets you write to the spefific file stream
			StreamWriter sw1 = new StreamWriter(fs1);
			// writing multiple lines
			sw1.WriteLine("This is the first line");
			sw1.WriteLine("This is the 2nd line");
			sw1.WriteLine("This is the 3rd line");
			sw1.WriteLine("This is the 4th line");
			// moves text from temp to file
			sw1.Flush();
			// must clsoe FileStream or we won't be able to see the text in the file.
			fs1.Close();


		}