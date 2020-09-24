using System;
using System.Xml;

namespace D_XmlDOM
{
    class XmlTest
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(
            "<책>"+ 
                "<제목>NET과 xml</제목>"+
                "<가격>19000</가격>"+
                "<저자>홍길동</저자>"+
            "</책>");
            doc.Save("Test.xml");
        }
    }
}
