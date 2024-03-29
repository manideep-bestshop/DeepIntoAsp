using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagementArrays
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an array of integers
            int[] numbers = new int[5];

            // Assigning values to array elements
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * 10;
            }

            // Printing array elements
            Console.WriteLine("Array elements:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // Creating a string
            string message = "Hello, world!";

            // Modifying the string
            message += " How are you?";

            // Printing the string
            Console.WriteLine(message);

            // Creating a list of strings
            List<string> fruits = new List<string>();

            // Adding elements to the list
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Orange");

            // Removing an element from the list
            fruits.Remove("Banana");

            // Printing the list elements
            Console.WriteLine("List elements:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Creating instances of Person class
            Person person1 = new Person("Alice", 30);
            Person person2 = new Person("Bob", 25);

            // Printing details of persons
            Console.WriteLine($"Person 1: Name - {person1.Name}, Age - {person1.Age}");
            Console.WriteLine($"Person 2: Name - {person2.Name}, Age - {person2.Age}");
        }
    }
}
