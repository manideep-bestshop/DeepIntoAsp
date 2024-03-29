using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an object
            MyClass obj = new MyClass();

            // Use the object
            obj.PrintMessage();

            // Let's make obj eligible for garbage collection
            obj = null;

            // At this point, the object created earlier is no longer in use
            // and will be automatically garbage collected by the runtime
            // The memory associated with it will be deallocated.
        }
    }
    class MyClass
    {
        public void PrintMessage()
        {
            Console.WriteLine("Hello, world....");
        }
    }
}
