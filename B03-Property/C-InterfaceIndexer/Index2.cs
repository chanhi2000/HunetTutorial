using System;

namespace C_InterfaceIndexer
{
    public interface ITest
    {
        int this[int idx]
        { get; set; }
    }
    class MyClass: ITest
    {
        private int[] arr = new int[100];
        public int this[int idx]
        {
            get 
            {
                if (idx <0 || idx >= 100) return 0;
                else return arr[idx];
            }
            set
            {
                if (!(idx<0 || idx >= 100))
                    arr[idx] = value;

            }
        }
    }
    public class Index2
    {
        public static void Main(string[] args)
        {
            MyClass test = new MyClass();
            test[2] = 4;
            test[5] = 32;
            for (int i=0; i<=10; i++)
            {
                Console.WriteLine("Element #{0} = {1}", i, test[i]);
            }
        }
    }
}
