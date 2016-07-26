using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_38_Extension_method
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This is custom string for extension method";
            int i = str.WordCount();
            Console.WriteLine("Word count: {0}", i);
            Console.ReadLine();
        }
    }

    public static class Extension
    { 
        public static int WordCount(this string str)
        {
            return str.Split(new char[] {' ', '.', ',', '?', '!'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

}
