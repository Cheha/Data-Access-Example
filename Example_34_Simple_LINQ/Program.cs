using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_34_Simple_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Data Source
            int[] numbers = new int[5] { 4,5,6,7,8};

            // 2. Query creation
            var numQuery = from num in numbers
                           where (num % 2) == 0
                           select num;
            
            // 3. Query execution
            foreach (int q in numQuery) {
                Console.Write("{0} ", q);
            }
            Console.ReadLine();
        }
    }
}
