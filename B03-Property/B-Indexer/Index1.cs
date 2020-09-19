using System;

namespace B_Indexer
{
    public class Index1
    {
        private int[] myArray = new int[100];
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= 100) return 0;
                else return myArray[index];
            }
            set
            {
                if (!(index <0 || index >= 100))
                    myArray[index] = value;
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Index1 b = new Index1();
            for (int i=0; i<=100; i++)
            {
                b[i] = i;
                Console.WriteLine("Element #{0} = {1}", i, b[i]);
            }
            Console.WriteLine(b[119]);
        }
    }
}
