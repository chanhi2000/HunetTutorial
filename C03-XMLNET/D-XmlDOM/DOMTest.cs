using System;
using System.Xml;

namespace D_XmlDOM
{
    public class DOMTest
    {
        public static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Logintest.xml");
            XmlElement first = (XmlElement) doc.DocumentElement.FirstChild;
            System.Console.WriteLine(first.ToString());

            XmlElement Loginid = (XmlElement) first.GetElementsByTagName("login_id")[0];
            XmlElement Loginpw = (XmlElement) first.GetElementsByTagName("login_pwd")[0];

            System.Console.WriteLine("Login_id={0}, Login_pwd={1}", Loginid.InnerText, Loginpw.InnerText);
        }
    }
}