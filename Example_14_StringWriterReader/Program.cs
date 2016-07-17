using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_14_StringWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StringWriter strWriter = new StringWriter())
            {
                strWriter.WriteLine("Don't forget Mother's Day this year...");
                Console.WriteLine("Contents of StringWriter:\n{0}", strWriter);
                // Read data from the StringWriter.
                using (StringReader strReader = new StringReader(strWriter.ToString()))
                {
                    string input = null;
                    while ((input = strReader.ReadLine()) != null)
                    {
                        Console.WriteLine(input);
                    }
                }
                Console.ReadLine();
            } 
        }
    }
}
