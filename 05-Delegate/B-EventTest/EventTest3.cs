using System;

namespace B_EventTest
{
    delegate void ent(string msg);
    class EventTest
    {
        public event ent name;
        public void MYPRN()
        {
            name("홍길동");
        }
    }
    class Test
    {
        public void MyAAA(string name)
        {
            Console.WriteLine("내가 만든 예쁜 이벤트다. " + name);
        }
        public void MyBBB(string name)
        {
            Console.WriteLine("내가 만든 못난이벤트다. " + name);
        }
    }
    public class EventTest3
    {
        public static void Main()
        {
            Test t = new Test();
            EventTest et = new EventTest();
            et.name += new ent(t.MyAAA);
            et.MYPRN();
            et.name += new ent(t.MyBBB);
            et.MYPRN();
        }
    }
}