using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System;
using System.IO;
using System.Xml.Serialization;


namespace ConsoleApp5
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var person = new Person
            {
                Name = "Олексій",
                Age = 30
            };

            // Серіалізація об'єкта в XML
            using (var writer = new StreamWriter("person.xml"))
            {
                var serializer = new XmlSerializer(typeof(Person));
                serializer.Serialize(writer, person);
                Console.WriteLine("Об'єкт успішно серіалізовано в person.xml");
            }

            // Десеріалізація об'єкта з XML
            using (var reader = new StreamReader("person.xml"))
            {
                var serializer = new XmlSerializer(typeof(Person));
                var deserializedPerson = (Person)serializer.Deserialize(reader);
                Console.WriteLine($"Десеріалізований об'єкт: Name = {deserializedPerson.Name}, Age = {deserializedPerson.Age}");
                Console.ReadKey();
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
