using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Problems
{
    internal class MonthlyPayment
    {
        public static void GetMonthlyPayment()
        {
            Console.WriteLine("Welcome to Monthly Payment Programme.");
            Console.WriteLine("Enter Principal Loan amount: ");
            double P = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the year : ");
            double Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the rate of Interest : ");
            double R = Convert.ToDouble(Console.ReadLine());

            double n = Y * 12;
            double r = R / (12 * 100);
            double Payment = P * r / 1 - Math.Pow((1 - r), -n);

            Console.WriteLine("Payment = " +Payment);
     
        }
    }
}
