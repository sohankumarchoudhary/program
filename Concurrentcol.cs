using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
namespace ConsoleApplication2
{
    class Concurrentcol
    {

        public static void Main()
        {
           var dict = new ConcurrentDictionary <string,int>();
            if (dict.TryAdd("k1", 53))
            {
                Console.WriteLine("Added");
            }
            if (dict.TryUpdate("k1", 12, 53))
            {
                Console.WriteLine("53 updated to 12");
            }
            dict["k1"] = 53; // Overwrite unconditionally
            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);
            int r2 = dict.GetOrAdd("k2", 3);
            Console.Read();
        }
    }
}

