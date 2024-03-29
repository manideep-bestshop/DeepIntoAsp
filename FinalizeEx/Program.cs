using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizeEx
{

    class Resource : IDisposable
    {
        private bool disposed = false;

        ~Resource()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources here
                    Console.WriteLine("Managed resources disposed.");
                }

                // Dispose unmanaged resources here
                Console.WriteLine("Unmanaged resources disposed.");
                disposed = true;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Resource resource = new Resource();

            // Using the resource...

            // Explicitly call Dispose
            resource.Dispose();
        }
    }
}
