Memory Management:
-----------------

Memory management in C# refers to the process of allocating and deallocating memory for objects during the execution of a program.
 In C#, memory management is primarily handled by the .NET Common Language Runtime (CLR) through a process called garbage collection. 
 Here are some key points about memory management in C#:

1.Automatic Memory Allocation: In C#, you typically use the new keyword to create objects. When you do this, 
  the CLR automatically allocates memory for the object on the managed heap.

2.Garbage Collection: C# utilizes a garbage collector that periodically scans the managed heap for objects that are no 
  longer referenced by the program. These unreferenced objects are considered garbage and are eligible for collection.
  The garbage collector then deallocates the memory associated with these objects, making it available for future allocations.

3.Managed Heap: In C#, objects are typically allocated on the managed heap. The managed heap is a region of memory managed by the CLR 
  where objects of managed types are stored.

4.Object Lifetimes: The CLR keeps track of references to objects. When an object is no longer referenced by any part of the program, 
  it becomes eligible for garbage collection. The garbage collector determines when to reclaim the memory occupied by these objects.

5.Finalization: C# allows you to define finalizers (also known as destructors) for objects. Finalizers are called by the garbage 
  collector before reclaiming the memory occupied by an object. Finalizers are primarily used for releasing unmanaged resources, 
  such as file handles or database connections.

6.IDisposable Interface: In addition to finalizers, C# provides the IDisposable interface for deterministic cleanup of resources. 
  Objects that implement IDisposable should be explicitly disposed of when they are no longer needed. 
  This ensures timely release of resources, especially unmanaged resources.

File I/O And Serialization
--------------------------
File I/O (Input/Output):

    File Input/Output in C# refers to the process of reading from and writing to files on the disk.
 This functionality allows programs to interact with external files for various purposes, such as storing configuration data,
 logging information, or processing large datasets.
 
Reading from Files: This involves opening an existing file, reading its contents, and processing the data.

Writing to Files: This involves creating a new file or overwriting an existing one with data provided by the program.

Appending to Files: This involves adding data to the end of an existing file without overwriting its contents. 

Serialization:
--------------
    Serialization is the process of converting an object into a format that can be easily stored or transmitted and then reconstructed later. 
In C#, objects can be serialized to various formats such as JSON, XML, binary, etc. Serialization is commonly used for tasks like
saving application state, sending data over a network, or persisting objects to storage.

Binary Serialization: Objects are converted into a binary format, which is more efficient but not human-readable.
XML Serialization: Objects are converted into XML format, which is human-readable but may be less efficient than binary serialization.
JSON Serialization: Objects are converted into JSON format, which is both human-readable and widely used for web communication.

ExceptionHandling:
------------------
It allows you to handle errors and unexpected situations

Try-Catch:
----------
 It allows you to wrap code that may potentially throw an exception inside a try block and catch and handle any exceptions that occur within a catch block.
 
 try
{
    // Code that may throw an exception
}
catch (Exception ex)
{
    // Handle the exception
    Console.WriteLine("An error occurred: " + ex.Message);
}
finally
{
    // Optional finally block for cleanup or additional actions
}

Types of Exceptions
-------------------
  exceptions are instances of classes derived from System.Exception. Some common exception types include System.NullReferenceException,
 System.ArgumentException, System.IO.IOException, etc.
 
try
{
    // Code that may throw an exception
}
catch (IOException ex)
{
    // Handle IO-related exceptions
}
catch (ArgumentException ex)
{
    // Handle argument-related exceptions
}
catch (Exception ex)
{
    // Catch all other exceptions
}

Finally Block
-------------
The finally block is optional and is used to specify code that should always be executed, regardless of whether an exception occurred or not. 

try
{
    // Code that may throw an exception
}
catch (Exception ex)
{
    // Handle the exception
}
finally
{
    // Cleanup code
}
Throwing Exceptions:
--------------------
You can manually throw exceptions using the throw keyword, allowing you to signal errors or exceptional conditions in your code. 

if (someCondition)
{
    throw new Exception("An error occurred.");
}
