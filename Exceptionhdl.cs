using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Exceptionhdl
    {
        public static void Main(string[] args)
        {
            Exceptionh2 o1 = new Exceptionh2();
            o1.display1();
           
         
            Console.Read();

        }
    }
    class Exceptionh2 
    {
       public  void display1()
        {
            unchecked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }

            try
            {
                int a, b, c;
                Console.WriteLine("enter value in a");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter value in b");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("quotient" + c);

                checked
                {
                    int val = int.MaxValue;
                    Console.WriteLine(val + 2);
                }

                // code for system exception 

                int[] arr = new int[3];
                arr[3] = 5;


            }

           

            catch(SystemException e1)
            {   
                Console.WriteLine("system exception " +e1);
                Console.WriteLine();

            }
            
            catch (Exception e)
            {

                
                Console.WriteLine("exception " + e.Message);
            }
            finally
            {
                Console.WriteLine("code is executed");
            }
        }
      

    }
}