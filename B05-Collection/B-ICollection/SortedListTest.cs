using System;
using System.Collections;

namespace B_ICollection
{
    public class SortedListTest
    {
        public static void Main(string[] args)
        {
            SortedList mySL = new SortedList();
            mySL.Add("홍길동", "World");
            mySL.Add("박길동", "!");
            mySL.Add("정길동", "Hello");
            System.Console.WriteLine("mySL");
            System.Console.WriteLine("\t Count:\t{0}", mySL.Count);
            System.Console.WriteLine("\t Capacity:{0}", mySL.Capacity);
            System.Console.WriteLine("\t Keys and Values");
            PrintKeysAndValues(mySL);
            Prn(mySL);
        }

        private static void Prn(SortedList mySL)
        {
            foreach (DictionaryEntry de in mySL)
            {
                System.Console.WriteLine("{0}\t {1}", de.Key, de.Value);
            }
        }
        private static void PrintKeysAndValues(SortedList myList)
        {
            System.Console.WriteLine("\t-KEY-\t-VALUE-");
            for (int i=0; i<myList.Count; i++)
            {
                System.Console.WriteLine("\t{0}:\t{1}", myList.GetKey(i), myList.GetByIndex(i));
            }
            System.Console.WriteLine();
        }
       
    }
}
