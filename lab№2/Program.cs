using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TrafficLight svet = new TrafficLight();
            TrafficLight.Event1 += svet.Green;
            TrafficLight.Event2 += svet.Red;
            for (int i = 1; i <= 5; i++)
            {
                Pedestrian pesh = new Pedestrian("Пешеход " + i);
                Driver vod = new Driver("Водитель " + i);
                TrafficLight.Event1 += pesh.Stand;
                TrafficLight.Event1 += vod.Ride;
                TrafficLight.Event2 += pesh.Go;
                TrafficLight.Event2 += vod.Stand;
                svet.ChangeLight(i);
            }
            Console.ReadKey();
        }
    }
    class TrafficLight
    {
        public delegate void Hadler();
        public static event Hadler Event1;
        public static event Hadler Event2;
        public void ChangeLight(int i)
        {
            if (i % 2 == 0)
            {
                Event2();
            }
            else
            {
                Event1();
            }
        }
        public void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Горит красный");
        }
        public void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Горит зеленый");
        }
    }
    class Driver
    {
        string name;
        public Driver() { }
        public Driver(string name)
        {
            this.name = name;
        }
        public void Ride()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0} еду", name);
            TrafficLight.Event1 -= this.Ride;
            TrafficLight.Event2 -= this.Stand;
        }
        public void Stand()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0} стою", name);
        }
    }
    class Pedestrian
    {
        string name;
        public Pedestrian() { }
        public Pedestrian(string name)
        {
            this.name = name;
        }
        public void Go()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0} иду", name);
            TrafficLight.Event1 -= this.Stand;
            TrafficLight.Event2 -= this.Go;
        }
        public void Stand()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0} стою", name);
        }
    }
}


