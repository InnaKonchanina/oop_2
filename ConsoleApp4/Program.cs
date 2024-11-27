using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Array<T> where T : IComparable, IAddOperation<T>
    {
        T[] elements;
        public Array(params T[] args)
        {
            elements = new T[args.Length];
            args.CopyTo(elements, 0);
        }
        public T this[int index]
        {
            set
            {
                if (index < 0 || index >= elements.Length)
                    throw new Exception("Індекс елемента виходить за межі масиву.");
                elements[index] = value;
            }
            get
            {
                if (index < 0 || index >= elements.Length)
                    throw new Exception("Індекс елемента виходить за межі масиву.");
                return elements[index];
            }
        }
        public int countGreaterThan(T elem)
        {
            int count = 0;
            foreach (T e in elements)
                if (e.CompareTo(elem) > 0)
                    count++;
            return count;
        }
        public T Sum()
        {
            T s = default(T);
            foreach (T e in elements)
                s = s.Add(s, e);
            return s;
        }
    }
    struct Integer:IComparable, IAddOperation<Integer>
    {
        public int value;
        public Integer(int v)
        {
            value = v;
        }
        public int CompareTo(object o)
        {
            Integer x = (Integer)o;
            if (value > x.value) return 1;
            if(value< x.value) return -1;
            return 0;
        }
        public Integer Add(Integer a, Integer b)
        {
            return new Integer(a.value + b.value);
        }
    }
    class Sorter
    {
        public static void SelectionSort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (array[j].CompareTo(array[index])
                        < 0)
                        index = j;
                T t= array[index];
                array[index] = array[i];
                array[i] = t;
            }
        }
    }
    interface IAddOperation<T>
    {
        T Add(T a, T b);
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Array<Integer> a = new Array<Integer>(new Integer(1), new Integer(2), new Integer(3));
            Console.WriteLine(a.Sum().value);
            Console.ReadKey();
        }
    }
}
