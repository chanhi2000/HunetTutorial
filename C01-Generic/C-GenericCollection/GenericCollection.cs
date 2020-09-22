using System;
using System.Collections.Generic;

namespace C_GenericCollection
{
    public class GenericCollection
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> openWith = new Dictionary<string, string>();
            openWith.Add("11", "월요일");
            openWith.Add("22", "화요일");
            openWith.Add("33", "수요일");
            openWith.Add("44", "목요일");
            try
            {
                openWith.Add("33", "금요일");
            }
            catch (ArgumentException)
            {
                System.Console.WriteLine("An element with Key = \"33\" already exists");
            }
        }
    }
}
