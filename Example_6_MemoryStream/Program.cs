using System;
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
            List<byte[]> byteList = new List<byte[]>();
            for (int i = 0; true; i++) {
                try
                {
                    byteList.Add(new byte[i * i * 10]);
                }
                catch (OutOfMemoryException e) {
                    Console.WriteLine(string.Format("byteList: {0}", i));
                }
            }
            Console.ReadLine();
        }
    }
}
