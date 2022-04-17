using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Problems
{
    internal class StopWat
    {
        public static void StpWch()
        {
            Console.WriteLine("Welcome to Stopwatch Programme.");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ReverseNumber.REVERSEtheNUMBER();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time = "+stopwatch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
