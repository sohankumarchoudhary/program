using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Generic<G>

    {
         public void  display(G s)
        {
            Console.WriteLine("value of s is " + s);
        }

    }
    class Genric2
    {
        public static void Main(string[] args)
        {
            Generic<string> obj1 = new Generic<string>();
            Generic<int> obj2 = new Generic<int>();
            obj1.display("hello");
            obj2.display(100);
            Console.Read();

        }
    }
}
