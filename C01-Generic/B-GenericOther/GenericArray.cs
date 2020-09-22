using System;
using System.Collections;
using System.Collections.Generic;

namespace B_GenericOther
{
    public class GenericArray
    {
        public static void Main(string[] args)
        {
            int[] arr = {0,1,2,3,4};
            List<int> list = new List<int>();

            for (int x=5; x<10;x++)
            {
                list.Add(x);
            }
            Prn(arr);
            Prn(list);
        }

        private static void Prn<T1>(IList<T1> at)
        {
            foreach(T1 item in at)
            {
                Console.Write(item.ToString()+ " ");
            }
            Console.WriteLine();
        }
    }
}
