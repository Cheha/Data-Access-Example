using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_9_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // StringBuilder Append
            StringBuilder builder = new StringBuilder();
            builder.Append("The list starts here:"); // Write
            builder.AppendLine(); // WriteLine
            builder.Append("1 cat").AppendLine();

            // Get a reference to the StringBuilder's buffer content.
            string innerString = builder.ToString();
            Console.WriteLine(innerString);

            // StringBuilder Replace
            builder = new StringBuilder("This is an example string that is an example.");
            builder.Replace("an", "the"); // Replaces 'an' with 'the'.
            Console.WriteLine(builder.ToString());
            
            
            // StringBuilder as Array
            builder = new StringBuilder();
            builder.Append("cat");

            Console.WriteLine(builder[1]);

            builder[0] = 'r';
            Console.WriteLine(builder.ToString());
            

            // StringBuider Remove
            builder = new StringBuilder("Dot Net Perls");
            builder.Remove(4, 3);
            Console.WriteLine(builder);




            Console.ReadLine();
        }
    }
}
