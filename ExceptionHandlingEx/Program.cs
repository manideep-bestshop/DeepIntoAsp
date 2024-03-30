using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 10;
                int y = 0;
                int result = x / y; // This will throw a DivideByZeroException
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division by zero error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Cleanup code executed.");
            }

        }
    }
}
