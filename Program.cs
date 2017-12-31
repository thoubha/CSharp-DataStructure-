using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 # into array");
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter Number " + (i + 1));
                string strinput = Console.ReadLine();
                arr[i] = int.Parse(strinput);
               
            }
            Console.WriteLine("Printing an array");
            for (int i = 0; i < arr.Length; i++)
            {
                //int max = 0; // if you set 0, then it's a wrong choice. what if user enters -ve number?
                int max = arr[0]; // so assign max should be one of the thing from array.
                int maxindex = 0;
                for (int m = 1; i < arr.Length; i++)
                {
                    if (max < arr[i])
                    {
                        max = arr[i];
                        maxindex = i;
                    }
                }
                Console.WriteLine("The max value entered " + max);
                int temp = arr[9];
                arr[9] = arr[maxindex];
                arr[maxindex] = temp;
            }
            
            Console.WriteLine("Printing an array after swap");
            for (int i = 1; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();

        }

        static void swap(int a,int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
