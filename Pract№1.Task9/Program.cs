using System.Diagnostics;
using System.Reflection;
using System.Xml;

namespace Pract_1.Task9
{
    class ProgrammingLanguage
    {
        public ProgrammingLanguage(string name, int appeared, string creator)
        {
            Name = name;
            Appeared = appeared;
            Creator = creator;
        }

        public string Name { get; }

        public int Appeared { get; }

        public string Creator { get; }

        public void PrintToConsole()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Appeared:{Appeared}");
            Console.WriteLine($"Creator:{Creator}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.Load("C:\\Users\\konch\\Desktop\\oop\\university\\oop_2\\Pract№1.Task9\\file.xml");

            var languages = new List<ProgrammingLanguage>();

            foreach (XmlNode node in xmlDocument.DocumentElement)
            {
                string name = node.Attributes.GetNamedItem("name").InnerText;
                int appeared = int.Parse(node["appeared"].InnerText);
                string creator = node["creator"].InnerText;
                languages.Add(new ProgrammingLanguage(name, appeared, creator));
            }
            foreach (ProgrammingLanguage language in languages)
            {
                language.PrintToConsole();
            }
            Console.ReadKey();
        }
    }
}
