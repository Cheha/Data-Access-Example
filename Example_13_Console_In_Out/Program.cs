using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_13_Console_In_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader tIn = Console.In;
            TextWriter tOut = Console.Out;

            tOut.WriteLine("Hola Mundo!");
            tOut.Write("What is your name: ");
            String name = tIn.ReadLine();

            tOut.WriteLine("Buenos Dias, {0}!", name);
            Console.ReadLine();
        }
    }
}
