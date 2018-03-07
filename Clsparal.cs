using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Clsparal
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Clsparal));

        public static void Main(string [] args)
        {
            Clsparal ob = new Clsparal();
            log4net.Config.BasicConfigurator.Configure();
            ob.Pfor();
            ob.ForeachP();
            Console.Read();
        }
        void Pfor()
        {
            int[] ar = new int[] { 2, 3, 5, 6, 7, 8 };
            Parallel.For(0, ar.Length, i =>
             {
                 log.Info(i);

             });
   
           
        }

        void ForeachP()
        {
            string[] colors = {
                                  "1. Red",
                                  "2. Green",
                                  "3. Blue",
                                  "4. Yellow",
                                  "5. White",
                                 
                              };
            Console.WriteLine("Traditional foreach loop\n");
            //start the stopwatch for "for" loop
            var sw = Stopwatch.StartNew();
            foreach (string color in colors)
            {
                log.InfoFormat("{0}, Thread Id= {1}", color, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
            log.InfoFormat("foreach loop execution time = {0} seconds\n", sw.Elapsed.TotalSeconds);
            log.Info("Using Parallel.ForEach");
            //start the stopwatch for "Parallel.ForEach"
            sw = Stopwatch.StartNew();
            Parallel.ForEach(colors, color =>
            {
                log.InfoFormat("{0}, Thread Id= {1}", color, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
            );
            log.InfoFormat("Parallel.ForEach() execution time = {0} seconds", sw.Elapsed.TotalSeconds);
            
        }

    }




}

