using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Programs
{
    internal class ReverseNumber
    {
        public static void Check2(int r) 
        {
            public static void ReverseNumber()
            {
                Console.WriteLine("Enter a number to reverse it");
                int num = Convert.ToInt32(Console.ReadLine());
                int n = num;
                int reverse = 0;
                while (n != 0)
                {
                    reverse = reverse * 10 + n % 10;
                    n = n / 10;
                }
                Console.WriteLine("Here is the reversed number: {0}", reverse);
            }
        }
    }
}
