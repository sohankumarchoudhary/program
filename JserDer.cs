using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ConsoleApplication4
{/// <summary>
/// class to show json serialize and deserialize
/// </summary>
    class JserDer
    {
        static string json;
        static JserDer jb;
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(JserDer));

        public static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(JserDer));

            jb = new JserDer();
            jb.Jslz();
            jb.Jdslz();

            Console.Read();


        }
        /// <summary>
        /// json serialize method
        /// </summary>
        void Jslz()
        {
            ProductInform ob1 = new ProductInform();
            ob1.pktdate = "feb2018";
            ob1.price = "199";
            ob1.pcode = "ind234";


            ProductInform ob2 = new ProductInform();
            ob2.pktdate = "feb2018";
            ob2.price = "99";
            ob2.pcode = "ind2123";
            List<ProductInform> l1 = new List<ProductInform>();
            l1.Add(ob1);
            l1.Add(ob2);
            Product p1 = new Product();
            p1.item = "biscuit";
            p1.id = 1;
            p1.data = l1;

            json = JsonConvert.SerializeObject(p1);


            jb.log.Info(" serialize object " + json);

            //  serialization of json in file location
            File.WriteAllText(@"E:\file.json", json);


        }
        /// <summary>
        /// json deserialize method
        /// </summary>

        void Jdslz()
        {

            // desrialize
            JObject jo = JObject.Parse(json);
            jb.log.Info("deserialize json object");
            Console.WriteLine(jo["item"]);
            Console.WriteLine(jo["id"]);
            Console.WriteLine(jo["data"][0]);
            Console.WriteLine(jo["data"][1]);

            foreach (var itm in jo["data"])
            {
                Console.WriteLine(itm);
            }
            // deserialization from file
            dynamic p2 = JsonConvert.DeserializeObject(File.ReadAllText(@"E:\file.json"));
            Console.WriteLine("data from json file");
          //  Console.WriteLine(p2.id);
          //  Console.WriteLine(p2.item);
            // Console.WriteLine(p2.data);
            foreach (var y in p2)
            {
                Console.WriteLine(y);

            }
        }
        /// <summary>
        /// class for product information
        /// </summary>
        public class ProductInform
        {
            public string pktdate { get; set; }
            public string price { get; set; }
            public string pcode { get; set; }


        }
        /// <summary>
        /// class for item name
        /// </summary>
        public class Product
        {
            public string item { get; set; }
            public int id { set; get; }
            public List<ProductInform> data { get; set; }

        }


    }
}


