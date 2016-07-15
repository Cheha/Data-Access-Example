using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter stWriter = new StreamWriter("Hello_StreamWriter_lesson.txt")) {
                stWriter.Write("Hello");
                stWriter.WriteLine("Hello line");
                stWriter.WriteLine("Hello new line");
            }
            
            // Append lines to the file
            using (StreamWriter stWriterNew = new StreamWriter("Hello_StreamWriter_lesson.txt", true))
            {
                stWriterNew.Write(" !");
                stWriterNew.Close();
            }
            Console.ReadLine();
        }
    }
}
