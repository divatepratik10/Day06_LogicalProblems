using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Problems
{
    internal class PerfectNumber
    {
        public static void FindPerfectNum()
        {
            Console.WriteLine("Welcome to Find Perfect Number Programe.");
            Console.WriteLine("Enter a number : ");
            int number, j = 0, n;
            number = Convert.ToInt32(Console.ReadLine());
            n = number;

            for(int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                    j = j + i;
                }
            }

            if(n == j)
            {
                Console.WriteLine("Entered number is Perfect number.");
            }
            else
            {
                Console.WriteLine("Entered  number is NOT Perfect number.");

            }
            //Console.WriteLine("{0}", j);
            Console.ReadLine();
        }
    }
}
