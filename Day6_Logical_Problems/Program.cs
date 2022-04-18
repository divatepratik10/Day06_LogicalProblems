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
            Console.WriteLine("Welcome to DAY-06 Logical Problem Programms.\n");
            Console.WriteLine("Choose between following options.\n");
            Console.WriteLine("1 : Fibonacci_Series\n2 : Perfect_Number\n3 : Prime_Number\n4 : Reverse_Number\n5 : Coupen_Number\n" +
                "6 : Stopwatch\n7 : Vending_Machine\n8 : Day_of_Week");
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
                case 6:
                    StopWat.StpWch();   
                    break;
                case 7:
                    VendingMachine.ReturnNotes();
                    break;
                case 8:
                    DayofWeek.FindDay();
                    break;
                default:
                    Console.WriteLine("something went wrong........");
                    break;

            }
            Console.ReadLine();


        }
    }
}
