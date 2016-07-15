using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;

namespace Example_12_Serialization
{
    [Serializable]
    public class DataSerializationClass
    {
        public int IntValue { get; set; }
        public double DoubleValue { get; set; }
        public string StringValue { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var serializableObj = new DataSerializationClass { DoubleValue = 5.5, IntValue = 4, StringValue = "Hello" };

            // Serialization
            IFormatter binFormatter = new BinaryFormatter();
            IFormatter soapFormatter = new SoapFormatter();
            XmlSerializer xmlSer = new XmlSerializer(typeof(DataSerializationClass));

            Stream binStream = new FileStream("MyBinFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            Stream soapStream = new FileStream("MySoapFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            FileStream xmlStream = new FileStream("MyXmlFile.xml", FileMode.Create, FileAccess.Write, FileShare.None);

            binFormatter.Serialize(binStream, serializableObj);
            soapFormatter.Serialize(soapStream, serializableObj);
            xmlSer.Serialize(xmlStream, serializableObj);

            binStream.Close();
            soapStream.Close();
            xmlStream.Close();

            Console.WriteLine("Object is serialized");

            // Deseriialization
            IFormatter binReadFormatter = new BinaryFormatter();
            IFormatter soapReadFormatter = new SoapFormatter();
            XmlSerializer xmlReadSer = new XmlSerializer(typeof(DataSerializationClass));

            Stream binReadStream = new FileStream("MyBinFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Stream soapReadStream = new FileStream("MySoapFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            FileStream xmlReadStream = new FileStream("MyXmlFile.xml", FileMode.Open, FileAccess.Read, FileShare.Read);

            DataSerializationClass obj1 = (DataSerializationClass)binReadFormatter.Deserialize(binReadStream);
            DataSerializationClass obj2 = (DataSerializationClass)soapReadFormatter.Deserialize(soapReadStream);
            DataSerializationClass obj3 = (DataSerializationClass)xmlReadSer.Deserialize(xmlReadStream);

            binReadStream.Close();
            soapReadStream.Close();
            xmlReadStream.Close();

            Console.WriteLine("Binary - int: {0}, double: {1}, str: {2}", obj1.IntValue, obj1.DoubleValue, obj1.StringValue);
            Console.WriteLine("SOAP - int: {0}, double: {1}, str: {2}", obj2.IntValue, obj2.DoubleValue, obj2.StringValue);
            Console.WriteLine("XML - int: {0}, double: {1}, str: {2}", obj3.IntValue, obj3.DoubleValue, obj3.StringValue);

            Console.ReadLine();
        }
    }
}
