using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_6_MemoryStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<byte[]> byteList = new List<byte[]>();
            //for (int i = 0; true; i++) {
            //    try
            //    {
            //        byteList.Add(new byte[i * i * 100]);
            //    }
            //    catch (OutOfMemoryException e) {
            //        Console.WriteLine(string.Format("byteList: {0}", i));
            //    }
            //}
            //Console.ReadLine();

            using (MemoryStream mStream = new MemoryStream())
            { 
                string memoryString = "I'm in computer memory!!!";
                byte[] buffer = Encoding.ASCII.GetBytes(memoryString);
                mStream.Write(buffer, 0, buffer.Length);

                Console.WriteLine(Encoding.Default.GetString(mStream.ToArray()));

                Console.ReadLine();
            
            }
        }
    }
}
