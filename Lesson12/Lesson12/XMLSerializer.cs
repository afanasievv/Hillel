
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using SecondLesson;

namespace Lesson12
{
    internal class XMLSerializer
    {
        private XmlSerializer serializer = new XmlSerializer(typeof(Mortar));

        public string Serialize(Mortar mortar)
        {
            var writer = new StringWriter();

            serializer.Serialize(writer, mortar);
            var xmlString = writer.ToString();

            Console.WriteLine(xmlString);
            return xmlString;
        }

        public Mortar Deserialize(string data)
        {
            var reader = new StringReader(data);
            var deserializedEmployee = (Mortar)serializer.Deserialize(reader);
            Console.WriteLine(deserializedEmployee);
            return deserializedEmployee;
        }
    }
}
