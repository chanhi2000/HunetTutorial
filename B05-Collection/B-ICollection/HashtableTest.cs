using System;
using System.Collections ;

namespace B_ICollection
{
    public class HashtableTest
    {
        public static void Main(string[] args)
        {
            Hashtable openWith = new Hashtable();
            openWith.Add("AA", "월요일");
            openWith.Add("BB", "화요일");
            openWith.Add("CC", "수요일");
            openWith.Add("DD", "목요일");
            System.Console.WriteLine(openWith.ToString());
            Prn(openWith);
            System.Console.WriteLine(openWith.ContainsKey("DD"));
        }

        private static void Prn(Hashtable openWith)
        {
            System.Console.WriteLine();
            foreach(DictionaryEntry de in openWith)
            {
                System.Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }
        }
    }
}