using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApplication4
{/// <summary>
/// student class
/// </summary>
    [Serializable]

    class Stud
    {
       public  int roll;
       public string name;
        public Stud(int roll, string name)
        {
           this. roll = roll;
           this. name = name;
        }
    }
    /// <summary>
    /// class for seialization and deserializtion
    /// </summary>
    class Serialz
    {

        public static void Main(string[] args)
        {

            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Serialz));
            Serialz ob = new Serialz();
            ob.Slz();
            ob.Dslz();
            Console.Read();




        }

/// <summary>
/// method for serialization
/// </summary>
      public void Slz()
        {
           log4net.ILog log = log4net.LogManager.GetLogger(typeof(Serialz));
            try
            {
               
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("e:\\F1.txt", FileMode.OpenOrCreate);
                Stud s = new Stud(2, "abc");
                formatter.Serialize(stream, s);
                stream.Close();
               log.Info("serialization done");

            }
            catch (SerializationException se)
            {
                log.Info("Failed to serialize. Reason: " + se.Message);
            }
        }



        /// <summary>
        /// method for deserialization
        /// </summary>
         public void   Dslz()
            {
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
            try
            {
                FileStream stream = new FileStream("e:\\F1.txt", FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();

                Stud s = (Stud)formatter.Deserialize(stream);
                log.Info("value after deserialization");
                log.Info("Rollno: " + s.roll);
                log.Info("Name: " + s.name);

                stream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        
    }
}
    
    



