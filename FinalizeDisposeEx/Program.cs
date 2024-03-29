using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizeDisposeEx
{
//Finalize is used for cleanup of unmanaged resources, such as file handles or database connections.
//        It's called by the garbage collector before an object is reclaimed.
//Dispose is used for cleanup of managed and unmanaged resources. It's called explicitly by the developer
//    to release resources when they're no longer needed.
    class MyClass : IDisposable
    {
        // Managed resource
        private bool _disposed = false;

        // Unmanaged resource
        private IntPtr _unmanagedResource;

        // Constructor
        public MyClass()
        {
            // Allocate unmanaged resource
            _unmanagedResource = System.Runtime.InteropServices.Marshal.AllocHGlobal(100);
            Console.WriteLine("Object created.");
        }

        // Finalizer
        ~MyClass()
        {
            Dispose(false);
        }

        // Dispose method
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Dispose(bool disposing) method
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Dispose of managed resources
                    // No managed resources in this example
                }

                // Dispose of unmanaged resources
                if (_unmanagedResource != IntPtr.Zero)
                {
                    System.Runtime.InteropServices.Marshal.FreeHGlobal(_unmanagedResource);
                    _unmanagedResource = IntPtr.Zero;
                }

                Console.WriteLine("Object disposed.");
                _disposed = true;
            }
        }

        public void SomeMethod()
        {
            if (_disposed)
                throw new ObjectDisposedException("MyClass");

            Console.WriteLine("SomeMethod called.");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            using (MyClass obj = new MyClass())
            {
                obj.SomeMethod();
            }

            // Or, without using block
            // MyClass obj = new MyClass();
            // obj.SomeMethod();
            // obj.Dispose();
        }
    }
}
