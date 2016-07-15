using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Example_10_Regex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = { "000-111-22-33", "00-111-22-33" };
            string pattern = @"^\d{3}-\d{3}-\d{2}-\d{2}$";
            foreach (string value in values) {
                if (Regex.IsMatch(value, pattern))
                {
                    Console.WriteLine("{0} is a valid phone", value);
                }
                else {
                    Console.WriteLine("{0} is invalid phone", value);                }            }
            Console.ReadLine();
        }
    }
}
