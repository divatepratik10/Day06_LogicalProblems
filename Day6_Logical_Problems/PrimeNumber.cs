using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Problems
{
    internal class PrimeNumber
    {
        public static void Findprime()
        {
            Console.WriteLine("Welcome to Find Prime Number Programme.");
            Console.WriteLine("Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int m = num / 2;
            int flag = 0;
            for(int i = 2;i<=m;i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Entered number {0} in NOT a Prime Number.",num);
                    flag = 1;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("Entered NUmber {0} is Prime Number.",num);
            }

            Console.ReadLine();

        }
    }
}
