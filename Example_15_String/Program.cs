using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_15_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Clone
            string firstString = "First string";
            object secondString = firstString.Clone();

            Console.WriteLine("String clone resut: {0}", secondString);
            Console.WriteLine(firstString.Equals(secondString.ToString()));
            Console.WriteLine("----------------");
            // String Compare
            // < 0 - string A goes first
            // > 0 - string B goes first
            string compareString = "Compare string";
            Console.WriteLine("String Compare result: {0}", String.Compare(firstString,
                compareString, true));
            Console.WriteLine("----------------");

            // String Concat
            string x = "Hello";
            string y = "World";
            Console.WriteLine("String Concat result: {0}", String.Concat(x, y));
            Console.WriteLine("----------------");

            // String Contains
            string firstText = "First";
            Console.WriteLine("String Contains result: {0}", firstString.Contains(firstText));
            Console.WriteLine("----------------");

            // String Copy
            string copyString = String.Copy(firstString);
            Console.WriteLine("String Copy result: {0}", copyString);
            Console.WriteLine(firstString.Equals(copyString));
            Console.WriteLine("----------------");

            // String IndexOf
            string searchStr = "str";
            Console.WriteLine("String IndexOf result: {0}", 
                firstString.IndexOf(searchStr));
            Console.WriteLine("----------------");

            // String Insert
            string insertStr = "insert";
            string strAfterInsert = firstString.Insert(4, insertStr);
            Console.WriteLine("String Insert result: {0}", strAfterInsert);
            Console.WriteLine("----------------");

            // String Remove
            string removedString = firstString.Remove(3, 3);
            Console.WriteLine("String Remove result: {0}", removedString);
            Console.WriteLine("----------------");

            // String Replace
            string searchString = "First";
            string replaceString = "Second";
            Console.WriteLine("String Replace result: {0}", 
                firstString.Replace(searchString, replaceString));
            Console.WriteLine("----------------");

            // String Split
            string stringForSplit = "This-is-example-of-split";
            string[] stringArr = stringForSplit.Split('-');
            foreach (string str in stringArr)
            {
                Console.Write(str + "   ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------");

            // String Substring
            string substractedStr = firstString.Substring(0, 5);
            Console.WriteLine("String Substring result: {0}", substractedStr);
            Console.WriteLine("----------------");

            // String Upper/Lower
            string inputString = "StrINg WitH DifF CasE";
            Console.WriteLine("ToUpper result: {0}", inputString.ToUpper());
            Console.WriteLine("ToLower result: {0}", inputString.ToLower());
            Console.WriteLine("----------------");

            // String Trim
            string trimString = "  This is text   ";
            Console.WriteLine("String Trim result: {0}", trimString.Trim());
            Console.WriteLine("----------------");


            Console.ReadLine();
        }
    }
}
