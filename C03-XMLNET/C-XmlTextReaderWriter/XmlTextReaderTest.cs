using System;
using System.IO;
using System.Xml;


namespace C_XmlTextReaderWriter
{
    public class XmlTextReaderTest
    {
        public static void Main(string[] args)
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(@"Logintest.xml");
                Prn(reader);
            }
            catch (XmlException xe)
            {
                System.Console.WriteLine("XML Parsing Error: "+xe);
            }
            catch (IOException ioe)
            {
                System.Console.WriteLine("File I/O Error: "+ioe);
                throw;
            }
        }

        public static void Prn(XmlTextReader reader)
        {
            while(reader.Read())
            {
                if (reader.Name.Equals("private") &&
                    reader.NodeType == XmlNodeType.Element)
                {
                    Disp(reader);
                }
            }

        }
        public static void Disp(XmlTextReader reader)
        {
            while(reader.NodeType != XmlNodeType.EndElement && reader.Read())
            {
                if(reader.NodeType == XmlNodeType.Element)
                {
                    switch(reader.Name)
                    {
                        case "name" :
                            System.Console.WriteLine(reader.ReadString());
                            reader.Read(); // 끝 태그를 사용합니다.
                            break;
                        case "age" :
                            System.Console.WriteLine(reader.ReadString());
                            reader.Read(); 
                            break;
                        case "address" :
                            System.Console.WriteLine(reader.ReadString());
                            reader.Read(); 
                            break;
                        case "tel" :
                            System.Console.WriteLine(reader.ReadString());
                            reader.Read(); 
                            break;
                    }
                }
            }
        }
    }
}