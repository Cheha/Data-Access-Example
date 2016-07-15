﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_8_StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = String.Format("0x{0:X} {0:E} {0:N}", Int64.MaxValue);
            Console.WriteLine(someString);
            string[] fnames = { "Ivan", "Petro", "Sydor" };
            string[] lnames = { "Ivanov", "Petrov", "Sydorov" };
            Console.WriteLine("{0,-20} {1,5}\n", "FirstName", "Last Name");
            for (int ctr = 0; ctr < fnames.Length; ctr++)
            {
                Console.WriteLine("{0,-20} {1,5:N1}", fnames[ctr], lnames[ctr]);
            }
            Console.ReadLine();
        }
    }
}
