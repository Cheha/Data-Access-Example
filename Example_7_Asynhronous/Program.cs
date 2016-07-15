using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_7_Asynhronous
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static Task Wrt() {
            string filePath = "Hello_asynch.txt";
            string text = "Hello_asynch\r\n";
            return WrAsynch(filePath, text);
        }

        static async Task WrAsynch(string filePath, string txt) {
            byte[] text = Encoding.Unicode.GetBytes(txt);
            using (FileStream stream = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.None,
                bufferSize: 4096, useAsync: true)) {
                    await stream.WriteAsync(text, 0, text.Length);
            }
        }
    }
}
