using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{ /// <summary>
/// class for Asyncnchronous programing
/// </summary>
    class Asyncprogram
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Asyncprogram));
        
        static Asyncprogram obj;

        /// <summary>
        /// it call Method1() and Method2()
        /// </summary>
        public  static  async void Method()
        {
            Task<int> task = Method1();
            Method2();
            int count = await task;
            Method3(count);
           

        }

        /// <summary>
        /// it contain Task
        /// and return count
        /// </summary>
        /// <returns></returns>


        public static async Task<int> Method1()
        {
           
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {

                    obj.log.Info("method1");
                    count += 1;
                }
            });
          

            return count;
            
            }


        public static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                obj.log.Info(" Method 2");
               
            }
        }


        public static void Method3(int count)
        {
            obj.log.Info("Total count is " + count);
            
        }
        static void Main(string[] args)
        {

            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Asyncprogram));

            obj = new Asyncprogram();

            Method();
            Console.Read();
            
        }


    }

}
