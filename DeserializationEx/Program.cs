using System;
using System.IO;

namespace DeserializationEx
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        Person person = new Person() { Name = "Manideep", Age = 28 }; 
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = "person.json";

            try
            {
                // Read the JSON data from the file
                string jsonData = File.ReadAllText(jsonFilePath);

                // Deserialize the JSON data to a Person object
                Person person = JsonConvert.DeserializeObject<Person>(jsonData);

                // Display the deserialized person
                Console.WriteLine("Deserialized Person:");
                Console.WriteLine(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during deserialization: {ex.Message}");
            }
        }
    }
}
