using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Emp
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
        String name;
        int age;
        int salary;

        string dept;

        public Emp(int age, string name, int salary, string dept)
        {
            this.age = age;
            this.name = name;
            this.salary = salary;
            this.dept = dept;
        }
        public object this[int i]
        {
            get
            {
                if (i == 1)
                    return age;
                else if (i == 2)
                    return name;
                else if (i == 3)
                    return salary;
                else if (i == 4)
                    return dept;
                return null;

            }
            set
            {
                if (i == 3)
                    salary = (int)value;
                if (i == 4)
                    dept = (string)value;

            }
        }

        class D
        {
            public static void Main(string[] args)
            {
                Emp e1 = new Emp(24, "ayush", 50000, "it engineer");
                Console.WriteLine("detais of employee");
                Console.WriteLine("name " + e1[1]);
                Console.WriteLine("age " + e1[2]);
                Console.WriteLine("salary " + e1[3]);
                Console.WriteLine("dept " + e1[4]);

                e1[3] = 40000;
                e1[4] = "assistant";
                Console.WriteLine("detais of employee after change");
                Console.WriteLine("detais of employee ");
                Console.WriteLine("name " + e1[1]);
                Console.WriteLine("age " + e1[2]);
                Console.WriteLine("salary " + e1[3]);
                Console.WriteLine("dept " + e1[4]);
                Class1.Testing();
                Console.ReadLine();

                Console.Read();


            }
        }

    }
}


   

