using System;
using System.Collections;

namespace A_IList
{
    public class ArrayListTest
    {
        public static void Main(string[] args)
        {
            ArrayList myAL = new ArrayList();
            System.Console.WriteLine("개수는 ={0} 용량={1}", myAL.Count, myAL.Capacity);
            myAL.Add("1.홍길동");
            myAL.Add("2.정길동");
            myAL.Add("3.황길동");
            myAL.Add("4.이길동");
            System.Console.WriteLine("개수는 ={0} 용량={1}", myAL.Count, myAL.Capacity);
        }
    }
}
