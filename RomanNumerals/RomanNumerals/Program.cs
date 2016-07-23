using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program converts an integer between 1 and 3999 to roman numerals." + Environment.NewLine);
            Console.Write("Please enter an integer: ");
            string input = Console.ReadLine();
            int valueToConvert;
            if (Int32.TryParse(input, out valueToConvert))
            {
                try
                {
                    string romanNumerals = RomanNumeralsConverter.FromInteger(valueToConvert);
                    Console.WriteLine(string.Format("Roman Numeral for {0} is {1}", valueToConvert, romanNumerals));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid value. Please enter a valid integer.");
            }
            Console.WriteLine(Environment.NewLine + "Press any key to continue...");
            Console.ReadKey();
        }
    }
}
