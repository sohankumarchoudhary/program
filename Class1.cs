using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication3
{
    class Class1
    {


        internal static void Testing()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
            try
            {
                log.Info("program for writing and reading from file");
                log.Error("error message");
            }
            catch (Exception ex)
            {
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
        }
        string file1 = "e:\\w.txt";
       
        StringWriter sw = new StringWriter();


        public void writef()
        {

            using (BinaryWriter bw = new BinaryWriter(File.Open(file1, FileMode.Create)))
            {
                bw.Write("hello");
                bw.Write(100);
                bw.Write(true);
            }

            // stringwriter


            sw.WriteLine("basics of c programing");

            sw.Close();
            // fileInfo
            try
            {
                FileInfo f1 = new FileInfo("e:\\abc.txt");
                StreamWriter s1 = f1.CreateText();
                s1.WriteLine("welcome to india");
                s1.Close();

            }
            catch (IOException e)
            {
                Console.WriteLine("SOME THING WENT WRONG " + e);
            }

        }

        public void readf()
        {
            using (BinaryReader br = new BinaryReader(File.Open(file1, FileMode.Open)))
            {
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadBoolean());
            }
            StringReader sr = new StringReader(sw.ToString());
            while (sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }

            // reading in fileInfo
            try
            {
                FileInfo f2 = new FileInfo("e:\\abc.txt");
                StreamReader str = f2.OpenText();
                string data = "";
                while ((data = str.ReadLine()) != null)
                {
                    Console.WriteLine("Fileinfo " + data);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("error" + e);
            }

        }
    }
  class A
        {
            public static void Main(string[] args)
            {
            Class1 ob = new Class1();
            ob.writef();
            ob.readf();
            Console.Read();
            Console.WriteLine("hello");
            Class1.Testing();
            Console.ReadLine();

        }
        }
    }

