using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Problems
{
    internal class ReverseNumber
    {
        public static int REVERSEtheNUMBER()
        {
            Console.WriteLine("Welcome to Reverse Number Programme.");
            Console.WriteLine("Enter a Numbr : ");
            int num = Convert.ToInt32(Console.ReadLine());//1234
            int remainder = 0, reverse = 0;
            while(num>0)
            {
                remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num = num / 10; 
            }
            Console.WriteLine("Reverse Number is {0}",reverse);
            return reverse;
        }
    }
}
