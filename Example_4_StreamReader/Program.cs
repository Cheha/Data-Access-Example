using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter stWriter = new StreamWriter("Hello_StreamWriter_lesson.txt"))
            {
                stWriter.Write("Hello");
                stWriter.WriteLine("Hello line");
                stWriter.WriteLine("Hello new line");
            }
            // Create file stream and then read data from stream
            using (FileStream flStream = new FileStream("Hello_StreamWriter_lesson.txt", FileMode.Open)) {
                using (StreamReader stReader = new StreamReader(flStream))
                {
                    Console.WriteLine(stReader.ReadToEnd());
                    stReader.Close();
                }
            }
            // Get data from file directly using StreamReader
            using (StreamReader stReader = new StreamReader("Hello_StreamWriter_lesson.txt", Encoding.Default)) {
                char[] charArr = new char[11];
                stReader.Read(charArr, 0, 8);
                Console.WriteLine(charArr);
            }
            Console.ReadLine();
        }
    }
}
