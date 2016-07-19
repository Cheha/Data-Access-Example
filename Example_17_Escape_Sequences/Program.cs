using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_17_Escape_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello, world";                  // hello, world
            string b = @"hello, world";                 // hello, world
            string c = "hello \t world";                // hello     world
            string d = @"hello \t world";               // hello \t world
            string e = "Joe said \"Hello\" to me";      // Joe said "Hello" to me
            string f = @"Joe said ""Hello"" to me";     // Joe said "Hello" to me
            string g = "\\\\server\\share\\file.txt";   // \\server\share\file.txt
            string h = @"\\server\share\file.txt";      // \\server\share\file.txt
            string i = "one\r\ntwo\r\nthree";
            string j = @"one
two
three";
        }
    }
}
