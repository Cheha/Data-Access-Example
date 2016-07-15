using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_5_BinaryReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fInfo = new FileInfo("Hello_io_binary.dat");
            using (BinaryWriter binWriter = new BinaryWriter(fInfo.OpenWrite())) {
                Console.WriteLine("Base stream is: {0}", binWriter.BaseStream);
                double aDouble = 2015.6;
                int aInt = 1233;
                string aString = "C, s, h";
                binWriter.Write(aDouble);
                binWriter.Write(aInt);
                binWriter.Write(aString);
                Console.WriteLine("Ok");
            }

            using (BinaryReader binReader = new BinaryReader(fInfo.OpenRead())) {
                Console.WriteLine(binReader.ReadDouble());
                Console.WriteLine(binReader.ReadInt32());
                Console.WriteLine(binReader.ReadString());
            }
            Console.ReadLine();
        }
    }
}
