using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File I/O - Writing to a file
            string filePath = "data.txt";
            File.WriteAllText(filePath, "Hello Manideep");

            // File I/O - Reading from a file
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Content: " + content);
        }
    }
}
