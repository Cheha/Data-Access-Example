using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_16_StringComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] cultureNames = { "en-US", "se-SE" };
            String[] strings1 = { "case",  "encyclopædia",  
                            "encyclopædia", "Archæology" };
            String[] strings2 = { "Case", "encyclopaedia", 
                            "encyclopedia" , "ARCHÆOLOGY" };
            StringComparison[] comparisons = (StringComparison[])Enum.GetValues(typeof(StringComparison));

            foreach (var cultureName in cultureNames)
            {
                Console.WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.Name);
                for (int ctr = 0; ctr <= strings1.GetUpperBound(0); ctr++)
                {
                    foreach (var comparison in comparisons)
                        Console.WriteLine("   {0} = {1} ({2}): {3}", strings1[ctr],
                                          strings2[ctr], comparison,
                                          String.Equals(strings1[ctr], strings2[ctr], comparison));

                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
