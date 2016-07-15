using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Example_11_MatchCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection matches;
            List<string> results = new List<string>();
            List<int> matchPosition = new List<int>();

            Regex reg = new Regex("text");
            matches = reg.Matches("There is text about regular expression.Text include several words \"text\"");

            foreach (Match match in matches) {
                results.Add(match.Value);
                matchPosition.Add(match.Index);
            }

            for (int i = 0; i < results.Count; i++) {
                Console.WriteLine("'{0}' found at position {1}.", results[i], matchPosition[i]);
            }

            Console.ReadLine();
        }
    }
}
