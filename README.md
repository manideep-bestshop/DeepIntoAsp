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
