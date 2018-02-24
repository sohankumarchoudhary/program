using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Collection1
    {
        public static void Main(string[] args)
        {
            collection2 obj = new ConsoleApplication2.collection2();
            obj.display();

            Console.Read();
             

        }
    }

      

    class collection2

    {
        List<string> l1 = new List<string>() { "hello", "to", "all" };
        HashSet<int> hst = new HashSet<int>() { 2, 5, 1, 5, 6 };
        SortedSet<int> st = new SortedSet<int>() { 3, 7, 9, 2, 4 };
        Stack<String> names = new Stack<string>() ;
       
        public void display()
        {
            Console.WriteLine("elements in list");
            foreach(String s in l1)
            {
                Console.Write(s +",");
            }
            Console.WriteLine();
            Console.WriteLine("elements in Hashset");
            foreach (int i in hst)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
            Console.WriteLine("elements in sortedset");
            foreach (int j in st)
            {
                Console.Write(j + ", ");
            }
            Console.WriteLine();
            names.Push("abc");
            names.Push("xyz");
            names.Push("aman");
            names.Push("rahul");

            Console.WriteLine("elements in stack");
            foreach (string  s2 in names)
            {
                Console.Write(s2 + ",");
            }
            Console.WriteLine();
            Console.WriteLine("peek element : " + names.Peek());
            Console.WriteLine("pop element : " + names.Pop());
            Console.WriteLine("peek element  after pop : " + names.Peek());



        }


    }
    
}
