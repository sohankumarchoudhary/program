using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{ 
/// <summary>
/// interface Iarea 
/// </summary>
    interface Iarea
    {
        double Sarea();
    }


    /// <summary>
    /// class Area implements Iarea
    /// </summary>
    public class Area : Iarea
    {
        double l;
        double b;
        /// <summary>
        /// constructor for getting values in length and breath
        /// </summary>
        /// <param name="length"></param>
        /// <param name="breadth"></param>
        public Area(double length, double breadth)
        {
            l = length;
            b = breadth;
        }
        /// <summary>
        /// Sarea return area of shape
        /// </summary>
        /// <returns></returns>
        public double Sarea()
        {
            return (l * b);
        }
    }
    /// <summary>
    /// class for Triangle Area
    /// </summary>
    public class Tarea : Iarea
    {
        double h, b;
        /// <summary>
        /// ti gives area of triangle
        /// </summary>
        /// <param name="h1"></param>
        /// <param name="b1"></param>
        public Tarea(double h1, double b1)
        {
            h = h1;
            b = b1;
        }
        /// <summary>
        /// it gives Triangle Area
        /// </summary>
        /// <returns>area of triangle</returns>
        public double Sarea()
        {
            return (0.5 * b * h);
        }

    }



    class A1
    {
        public static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
            Area OB = new Area(2.5, 5);
            Tarea tb = new Tarea(5, 10);

            log.Info("area of rectangle is" + OB.Sarea());
            log.Info("area of Triangle is" + tb.Sarea());
            Console.Read();
        }
    }
}