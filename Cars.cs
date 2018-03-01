using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{/// <summary>
///  this class shows use of abstract class
/// </summary>
 public  abstract  class Cars
    {
        
        

        /// <summary>
        /// abstract method price()
        /// </summary>

        public abstract double price();
        /// <summary>
        /// abstract method getTotalSeat()
        /// </summary>
       
            public abstract int getTotalSeat();
        /// <summary>
        /// abstract method colors()
        /// </summary>
       
            public abstract string colors();

          /// <summary>
          /// method wheel()
          /// </summary>
          /// <returns>return wheel = 4</returns>
            public string Wheel()
            {
                return "4 wheeler";

            }
        /// <summary>
        /// meyhod check ac is available
        /// </summary>
        /// <returns> Ac is available</returns>
            public string CheckAC()
            {
                return "AC is available";
            }
           
        }

    /// <summary>
    /// toyota class derived from class Cars
    /// </summary>

    public class Toyota : Cars
    {

        
        public string DiscountPrice()
        {
            return "20% discount on buying Toyoya Cars";
        }
        public override double price()
        {
            return 1000000.00;
        }
        public override int getTotalSeat()
        {
            return 5;
        }
        public override string colors()
        {
            return "Red";
        }

        static void Main(string[] args)
        {

            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
            Toyota Toy = new Toyota();
            log.Info("-------Common property defined commonly in Cars Class----------");



            log.Info(Toy.Wheel());
            log.Info(Toy.CheckAC());
            log.Info("-------Own property defined in Toyota class------------");
            log.Info(Toy.DiscountPrice());
            log.Info(Toy.getTotalSeat());
            log.Info(Toy.colors());
            

            Console.ReadLine();


        }
    }


}





