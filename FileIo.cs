using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication2
{
    class E
    {


        
        public void writef()
            
        {

            FileStream f1 = new FileStream("e:\\a.txt", FileMode.OpenOrCreate);
            FileStream f2 = new FileStream("e:\\b.txt", FileMode.OpenOrCreate);


           
            for (int i = 65; i <= 90; i++)
            {
                f1.WriteByte((byte)i);
            }
            f1.Close();

           

            // streamwriter example
            StreamWriter sw = new StreamWriter(f2);
            sw.WriteLine("c#filesystem");
            sw.Close();
            f2.Close();

            // text writer
            using (TextWriter tw = File.CreateText("e:\\b.txt"))
            {
                tw.WriteLine("hello to all");
                tw.WriteLine("welcome to c# project");
            }

        }
        public void readf()
        {
            FileStream f1 = new FileStream("e:\\a.txt", FileMode.OpenOrCreate);
            FileStream f2 = new FileStream("e:\\b.txt", FileMode.OpenOrCreate);
             
            // Reading byte from file stream
            int i = 0;
            Console.WriteLine("reading byte from stream ");
            while ((i = f1.ReadByte()) != -1)
            {
                Console.Write( (char)i);
            }
            f1.Close();
            Console.WriteLine();
            Console.WriteLine("................");


            StreamReader sr = new StreamReader(f2);
             string line =sr.ReadLine();
            Console.WriteLine(" reading using steamReader " + line);
            sr.Close();
            f2.Close();

            Console.WriteLine(".......................");

            // text reader

            using (TextReader tr = File.OpenText("e:\\b.txt") )
            {
                Console.WriteLine( "reading by textreader " + tr.ReadToEnd());
            }
        }
       
    }
    class Filesystem
    {
        public static void Main(string[] args)
        {
            E o1 = new E();
            o1.writef();
            o1.readf();
            Console.WriteLine("done");
            Console.Read();
        }

    }
}
