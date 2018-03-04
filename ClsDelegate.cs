using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{/// <summary>
/// class showing delegate and event use
/// </summary>
    class ClsDelegate
    {  /// <summary>
       /// delegate defination
       /// </summary>
       /// <param name="a"></param>
       /// <param name="b"></param>
        public delegate void Delegatefun(int a, int b);
        /// <summary>
        /// event declaration
        /// </summary>
        public static event Delegatefun ev1;
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
        /// <summary>
        /// Aaa() to add
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Add(int a, int b)
        {
            log.Info("sum is " + (a + b));
        }
        /// <summary>
        /// mul() to multiply a and b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void mul(int a, int b)
        {
            log.Info("product is " + (a * b));
        }


        public static void Main(String[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
            ClsDelegate ob = new ClsDelegate();
            //  Delegatefun objd = new Delegatefun(ob.Add);
            ev1 += new Delegatefun(ob.Add);
            ev1 += new Delegatefun(ob.mul);
            ev1(3, 4);
            Console.Read();
        }

    }
}
