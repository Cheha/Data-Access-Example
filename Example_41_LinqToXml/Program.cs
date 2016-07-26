using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Example_41_LinqToXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = XElement.Load("LINQOperationXML.xml");

            var contacts = from el in root.Elements("contact")
                           where el.Element("lastName").Value == "Springwater"
                           select el;
            foreach(var el in contacts) {
                Console.WriteLine(el);
            }
            Console.ReadLine();
        }
    }
}
