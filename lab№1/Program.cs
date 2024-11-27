using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Example 1
            Console.WriteLine("Example 1");
            Random o = new Random();
            List<int> chisla = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                chisla.Add(o.Next(1, 20));
                Console.Write("{0} ", chisla[i]);
            }
            //Example 2
            int mx = chisla[0];
            int nmx = 0;
            for (int i = 1; i < chisla.Count; i++)
            {
                if (chisla[i] > mx)
                {
                    mx = chisla[i];
                    nmx = i;
                }
            }
            Console.WriteLine("\nExample 2: {0} {1}", mx, nmx);
            Console.ReadKey();

        }
    }
}
