using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Example_33_Json
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { Name = "Alex", Age = 44 };
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));
            MemoryStream stream = new MemoryStream();
            serializer.WriteObject(stream, person);
            string jsonString = Encoding.UTF8.GetString(stream.ToArray());
            stream.Close();
            Console.WriteLine(jsonString);

            // Deserializing
            MemoryStream newStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            Person newPerson = (Person)serializer.ReadObject(newStream);
            Console.WriteLine("{0} {1}", newPerson.Age, newPerson.Name);
            Console.ReadLine();
        }
    }


    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
