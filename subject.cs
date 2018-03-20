using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class subject
    { 
        public static void Main(string []args)
        {
            var subject1 = new Subject <string>();
            writeseq(subject1);
            subject1.OnNext("a");
            subject1.OnNext("a2");
            subject1.OnNext("a3");
            Console.ReadKey();
        }


        static void writeseq(IObservable<string> sequence)
        {
            sequence.Subscribe(Console.WriteLine);
        }
    }
}
