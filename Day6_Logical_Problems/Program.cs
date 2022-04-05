using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DAY-06 Logical Problem Programms.");
            int n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                case 1:
                    _1FibonacciSeries.FiboSeries();
                    Console.ReadLine();
                    break;
                case 2:
                    PerfectNumber.FindPerfectNum();
                    break;
                case 3:
                    PrimeNumber.Findprime();
                    break;
                case 4:
                    ReverseNumber.REVERSEtheNUMBER();
                    break;
                case 5:
                    CouponNumber.DistinctCoupon();
                    break;
                default:
                    Console.WriteLine("something went wrong........");
                    break;

            }
            Console.ReadLine();


        }
    }
}
