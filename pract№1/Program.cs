using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace pract_1
{
    class Cars
    {
        public static List<Shop> CarsList = new List<Shop>();
        public static void Add(Shop s)
        {
            CarsList.Add(s);
        }
        public static void Show()
        {
            foreach (Shop i in CarsList)
            {
                i.PrintToConsole();
            }
        }
    }
    class Shop
    {
        public string Id { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public int Price { get; private set; }
        public Shop(string id, string model, int year, int price)
        {
            Id = id;
            Model = model;
            Year = year;
            Price = price;
        }
        public void PrintToConsole()
        {
            Console.WriteLine($"Автосалон:{Id}");
            Console.WriteLine($"Марка:{Model}");
            Console.WriteLine($"Рік:{Year}");
            Console.WriteLine($"Ціна:{Price}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            XmlDocument xml = new XmlDocument();
            xml.Load(@"C:\Users\konch\Desktop\new 1.xml");
            foreach (XmlNode node in xml.DocumentElement)
            {
                string id = node.Attributes[0].InnerText;
                string model = node["model"].InnerText;
                int year = Int32.Parse(node["year"].InnerText);
                int price = Int32.Parse(node["price"].InnerText);
                Cars.Add(new Shop(id, model, year, price));
            }
            Cars.Show();
            Console.ReadKey();
        }
    }
}



