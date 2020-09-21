using System;
using System.Collections;

namespace B_ICollection
{
    class StackTest
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push("안녕하세요");
            myStack.Push("좋은 하루입니다.");
            myStack.Push("오늘도 팟팅하세요!");
            Console.WriteLine("myStack");
            Console.WriteLine("\tCount: {0}", myStack.Count);
            Console.Write("\tValues:");
            Prn(myStack);
        }

        private static void Prn(Stack myStack)
        {
            Console.WriteLine("{0,10}", myStack.Count);
            myStack.Peek(); // 개체를 제거하지않고 반환
            // myStack.Pop(); // 개체를 제거하고 반환
            IEnumerator ir = myStack.GetEnumerator();
            while(ir.MoveNext())
            {
                Console.WriteLine(ir.Current.ToString());
            }
        }
    }
}
