using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;

namespace ConsoleApplication4
{
    class rxnet
    {
        private static void Main(string[] args)
        {
            IObservable<string> obj = Observable.Generate(
              0,
              _ => true,
              i => i + 1,
                i => new string('#', i),
                i => TimeSelector(i));
            // subscribe here 
            using (obj.Subscribe(Console.WriteLine))
            {
                Console.WriteLine("press any key to stop");
                Console.ReadLine();
            }
        }
            

            // returns time selector
            private static TimeSpan TimeSelector(int i)
        {
            return TimeSpan.FromSeconds(i);
        }

        }
    }



