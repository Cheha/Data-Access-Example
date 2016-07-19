using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
                using (FileStream fileStr = File.Open("Hello.txt", FileMode.Create))
                {
                    string message = "Hello I/O";
                    byte[] message_bytes = Encoding.ASCII.GetBytes(message);
                    fileStr.Write(message_bytes, 0, message_bytes.Length);
                    fileStr.Position = 0;
                    Console.WriteLine("Array of bytes: ");

                    byte[] message_from_file = new byte[message_bytes.Length];
                    for (int i = 0; i < message_bytes.Length; i++)
                    {
                        message_from_file[i] = (byte)fileStr.ReadByte();
                        Console.Write(message_from_file[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Decoded message: ");
                    Console.WriteLine(Encoding.Default.GetString(message_from_file));
                    Console.ReadLine();
                }
           
        }
    }
}
