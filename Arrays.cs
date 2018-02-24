using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Arrays
    {
        public static void Main(string[] args)
        {

            int[] arr = new int[5] { 1, 2, 3, 4, 5 }; // 1d array
            Console.WriteLine("element in 1d array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("element in 2d array");



            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };//declaration and initialization  

            //traversal  
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr2[i,j]);
                }
                Console.WriteLine();//new line at each row  
            }


            int[][] arr3 = new int[2][];
            arr3[0] = new int[] { 1, 2, 3 };
            arr3[1] = new int[] { 2, 3, 5 };

            Console.WriteLine("elements in jagged array");

            for (int k = 0; k < arr3.Length; k++)
            {
                for (int l = 0; l < arr3[k].Length; l++)
                {
                    Console.Write(arr3[k][l] + " ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }


    }
}


