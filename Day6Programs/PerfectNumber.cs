using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Programs
{
    internal class PerfectNumber
    {
        public static void Check1(int p)
        {
           
            bool isPerfect = IsPerfectNum(p);
            Console.WriteLine($"{p} is{(isPerfect ? "" : " not")} a perfect number.");
        }  
         
        static bool IsPerfectNum(int p) 
        {
            int sum = 0;

            for (int i = 1; i < p; i++)
            {
                if (p % i == 0)
                {
                    sum += i;
                }
            }
            return sum == p;
        }
           
        
    }
}
