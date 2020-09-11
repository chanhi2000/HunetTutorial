using System;

namespace B_EventTest
{
    public delegate void ClickEvent();
    class Mouse
    {
        public static event ClickEvent Clicked;
        public void click()
        {
            Clicked();
        }
    }
    class Test
    {
        public static void Prn()
        {
            Console.WriteLine("안녕하세요");
        }
    }
    class EventTest
    {
        static void Main(string[] args)
        {
            Mouse m = new Mouse();
            Mouse.Clicked += new ClickEvent(Test.Prn);
            m.click();
        }
    }
}
