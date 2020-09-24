using System;
using System.Xml;

namespace A_XmlReader
{
    public class ReaderTest
    {
        public static void Main(string[] args)
        {
            using(XmlReader reader = XmlReader.Create(@"book.xml"))
            {
                while(reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (reader.IsEmptyElement)
                        {
                            Console.WriteLine("<{0}/>", reader.Name);
                        }
                        else 
                        {
                            Console.Write("<{0}>", reader.Name);
                            reader.Read();
                            if (reader.IsStartElement())
                            {
                                Console.Write("\r\n<{0}>", reader.Name);
                            }
                            Console.WriteLine(reader.ReadString());
                        }

                    }
                }
            }
        }
    }
}
