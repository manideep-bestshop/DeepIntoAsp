using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationEx
{
    // Sample class for serialization
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Serialization - XML Serialization
            Person person = new Person { Name = "Manideep", Age = 29 };
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            using (TextWriter writer = new StreamWriter("person.xml"))
            {
                serializer.Serialize(writer, person);
            }

            // Deserialization - XML Deserialization
            Person deserializedPerson;
            using (TextReader reader = new StreamReader("person.xml"))
            {
                deserializedPerson = (Person)serializer.Deserialize(reader);
            }
            Console.WriteLine($"Deserialized Person: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
        }
    }
    }

