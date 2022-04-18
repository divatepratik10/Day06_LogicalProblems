using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Problems
{
    internal class VendingMachine
    {
        public static void ReturnNotes()
        {
            Console.WriteLine("Enter the Amount to be returned by machine : ");
            int amt = Convert.ToInt32(Console.ReadLine());
            int[] notes = { 1000, 500, 100, 50, 10, 2, 1 };
            int temp = amt;

            for (int i = 0; i < notes.Length; i++)
            {
                int NOofNOTES = temp / notes[i];
                Console.WriteLine("{0} Rs. Notes are : {1}", notes[i], NOofNOTES); 
                temp %= notes[i];
            }

        }
    }
}
