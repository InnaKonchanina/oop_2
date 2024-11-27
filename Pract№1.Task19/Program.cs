using System.Diagnostics;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Pract_1.Task19
{
    class Staff
    {
        public Staff(int id, string firstname, string lastname, string nickname, int salary)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Nickname = nickname;
            Salary = salary;
        }
        public int Id { get; }
        public string Firstname { get; }

        public string Lastname { get; }

        public string Nickname { get; }

        public int Salary { get; }

        public void PrintToConsole()
        {
            Console.WriteLine($"Id:{Id}");
            Console.WriteLine($"Firstname:{Firstname}");
            Console.WriteLine($"Lastname:{Lastname}");
            Console.WriteLine($"Nickname:{Nickname}");
            Console.WriteLine($"Salary:{Salary}");
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding .UTF8;
            var xmlDocument = new XmlDocument();
            xmlDocument.Load("C:\\Users\\konch\\Desktop\\oop\\university\\oop_2\\Pract№1.Task19\\file2.xml");

            var company = new List<Staff>();

            foreach (XmlNode node in xmlDocument.DocumentElement)
            {
                int id = int.Parse(node.Attributes.GetNamedItem("id").InnerText);
                string firstname = node["firstname"].InnerText;
                string lastname = node["lastname"].InnerText;
                string nickname = node["nickname"].InnerText;
                int salary = int.Parse(node["salary"].InnerText);
                company.Add(new Staff(id, firstname, lastname, nickname, salary));
            }
            foreach (Staff language in company)
            {
                language.PrintToConsole();
            }
            Console.ReadKey();
        }
    }
}
