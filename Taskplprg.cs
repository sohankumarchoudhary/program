using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication4
{/// <summary>
/// class for task parallel
/// </summary>
    class Taskplprg
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Taskplprg));
        static Taskplprg obj;
        public static void Main(string [] args)
        {
            obj = new Taskplprg();
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Taskplprg));
            log4net.ILog log1 = log4net.LogManager.GetLogger(typeof(Mthread));

            Tpl();
            Mthread  ob= new Mthread();

            Thread t1 = new Thread(new ThreadStart(ob.Tdisplay));
            Thread t2 = new Thread(new ThreadStart(ob.Tdisplay));
            t1.Start();
            t2.Start();
            Console.Read();

            
        }
        /// <summary>
        /// method to display task 
        /// </summary>
        static void Display()
        {
           obj.log.Info("hello");
        }
        /// <summary>
        /// method to define task parallel
        /// </summary>
        public static void Tpl()
        {

            Task t1 = new Task(new Action(Display));
           
            Task t2 = new Task(delegate { Display(); });
            Task t3 = new Task(() => Display());
            t1.Start();
            t2.Start();
            t3.Start();

           
        }

    }
    /// <summary>
    /// class for thread
    /// </summary>
     class Mthread
    {
        log4net.ILog log1 = log4net.LogManager.GetLogger(typeof(Mthread));
        /// <summary>
        /// method to display  synchronization of thread
        /// </summary>
        public void Tdisplay()
        {   lock (this)
            {
                for (int i = 1; i < 6; i++)
                {
                    log1.Info(i);
                }
            }
        }

    }
    
}
