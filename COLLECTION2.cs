using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class COLLECTION2
    {
        public static void Main(string[] args)
        {

            B b1 = new B();
            b1.display();
            Console.Read();

        }
    }
    class B
    {
        Queue<string> q = new Queue<string>();
        LinkedList<string> lt = new LinkedList<string>();
        Dictionary<int, string> dc = new Dictionary<int, string>();
        SortedDictionary<int, string> sd = new SortedDictionary<int, string>();
        SortedList<string, string> sl = new SortedList<string, string>();

       public void display()
        {
            q.Enqueue("RAHUL");
            q.Enqueue("RAM");
            q.Enqueue("SIVA");

            Console.WriteLine("elements in queue ");
            foreach (String s in q)
            {
                Console.Write(s + ",");
            }
            Console.WriteLine("peek element: " + q.Peek());
            Console.WriteLine("dequeue" + q.Dequeue());
            Console.WriteLine("Element after dequeue: " + q.Peek());

            // linked list


            lt.AddLast("ajay");
            lt.AddLast("abc");
            lt.AddFirst("hello");
            Console.WriteLine("elements in linkedlist ");
            foreach (String l in lt)
            {
                Console.Write(l + ",");
            }

            Console.WriteLine();
           LinkedListNode <string> lt2 = lt.Find("abc"); 
            lt.AddBefore(lt2, "rahul"); // inserting element before abc
            lt.AddAfter(lt2, "ram"); // inserting element after abc
            Console.WriteLine("element after insertion");
           
            foreach (String l1 in lt)
            {
                Console.Write(l1 + ",");
            }


            // DICTIONARY

            dc.Add(1, "BTECH");
            dc.Add(2, "Mtech");
            dc.Add(3, "mca");
            Console.WriteLine();
            Console.WriteLine("element in dictionary");

            foreach (KeyValuePair<int, string> k in dc)
            {
                
                Console.WriteLine(k);
            }

            // sortedDictionary
            sd.Add(3, "btech");
            sd.Add(1, "Mtech");
            sd.Add(2, "mca");
            Console.WriteLine();
            Console.WriteLine("element in Sortedsdictionary");

            foreach (KeyValuePair<int, string> k1 in sd)
            {

                Console.WriteLine(k1);
            }


            // sorted list
            sl.Add("3", "vtu");
            sl.Add("1", "vbu");
            sl.Add("2", "Btu");
            Console.WriteLine();
            Console.WriteLine("element in Sortedlist");

            foreach(KeyValuePair<string, string> k2 in sl)
            {

                Console.WriteLine(k2);
            }








        }
    }
}