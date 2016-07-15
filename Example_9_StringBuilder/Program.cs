using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_9_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder strBuilder = new StringBuilder("Text string");
            strBuilder.Append(" new info - ");
            strBuilder.Append(4);
            strBuilder.Insert(11, "!");
            Console.WriteLine(strBuilder);
            Console.ReadLine();
        }
    }
}
