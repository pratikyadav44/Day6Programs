using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Programs
{
     class FibonacciSeries
    {
        public static void GenerateFibonacciNumb(int n)
        {

            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine("printing the series");
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
   
    

    }
}
