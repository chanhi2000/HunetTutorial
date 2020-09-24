using System;
using System.Xml;

namespace C_XmlTextReaderWriter
{
    public class XmlTextWriterTest
    {
        public static void Main(string[] args)
        {
            using(XmlTextWriter w = new XmlTextWriter(Console.Out)) 
            {
                w.Formatting = Formatting.Indented;
                w.WriteStartElement("private");
                w.WriteElementString("name", "홍길동");
                w.WriteElementString("age", "20");
                w.WriteElementString("address", "서울");
                w.WriteElementString("tel", "77-7777");
            }
        }
    }
}
