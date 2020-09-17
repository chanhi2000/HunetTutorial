using System;

namespace B_EventTest
{
    public delegate void Clicked();

    public class Form
    {
        public static event Clicked cc;
        public void Show()
        {
            cc();
        }
    }
    public class Myevent2
    {
        public static void abc()
        {
            Console.WriteLine("난 폼을 보여줍니다.");
        }
    }
    public class EventTest2
    {
        public static void Main()
        {
            Form f = new Form();
            Form.cc += new Clicked(Myevent2.abc);
            f.Show();
        }        
    }

}