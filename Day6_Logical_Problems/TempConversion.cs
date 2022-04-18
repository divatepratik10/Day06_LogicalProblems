using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Problems
{
    internal class TempConversion
    {
        public static void TemperatureConvert()
        {
            Console.WriteLine("Welcome to Temperature Conversion Programme.");
            Console.WriteLine("Enter Temperature : ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Temperature Unit. Type( 1-Celcius / 2-Fahrenheit )");
            int unit = Convert.ToInt32(Console.ReadLine());

            switch(unit)
            {
                case 1:
                    double res = (temperature * 9 / 5) + 32;
                    Console.WriteLine("{0} C temperature converted into {1} F. ",temperature,res);
                    break;
                case 2:
                    double res1 = (temperature - 32) * 5 / 9;
                    Console.WriteLine("{0} F temperature converted into {1} C. ", temperature, res1);
                    break;
                default:
                    Console.WriteLine("Enter Valid Inputs..");
                    break;
            }
        }
    }
}
