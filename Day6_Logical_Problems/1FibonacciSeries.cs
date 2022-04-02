using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Problems
{
    internal class _1FibonacciSeries
    {
        public static void FiboSeries()
        {
            Console.WriteLine("Welcome to Fibonacci Series Programme.");
            Console.WriteLine("Enter number of elements you want : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int n1 = 0, n2 = 1, n3;
            Console.WriteLine("    {0}\n    {1}", n1, n2);
            for(int i = 2;i<num;i++)
            {
                n3 = n1 + n2;
                Console.WriteLine("    {0}", n3);
                n1 = n2;
                n2 = n3; ;
            }
            Console.ReadLine();

        }
    }
}
