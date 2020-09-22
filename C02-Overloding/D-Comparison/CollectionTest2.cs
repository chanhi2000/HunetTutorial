using System;
using System.Collections.Generic;

namespace D_Comparison
{
    public class AscendingOrderComparer: IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x-y;
        }
    }
    public class DescendingOrderComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y-x;
        }
    }

    public class CollectionTest2
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] {3,6,7,4,2,0,1};
            
            System.Console.WriteLine("[before sort]");
            Print(arr);

            System.Console.WriteLine("[AscendingOrderComparer]");
            Array.Sort(arr, new AscendingOrderComparer());
            Print(arr);
            
            System.Console.WriteLine("[DescendingOrderComparer]");
            Array.Sort(arr, new DescendingOrderComparer());
            Print(arr);
        }

        public static void Print(IEnumerable<int> c)
        {
            foreach (int e in c)
            {
                Console.WriteLine(" {0} ",e);
            }
            Console.WriteLine();
        }
    }
}
