using System;
using System.Xml;

namespace B_XmlWriter
{
    public class XmlWriterTest
    {
        public static void Main(string[] args)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("   ");
            using (XmlWriter writer = XmlWriter.Create("books2.xml", settings))
            {
                writer.WriteStartElement("주소록");
                writer.WriteElementString("주소", "서울시 강남구 수서동");
                writer.WriteEndElement();
                writer.Flush();
            }
        }
    }
}

