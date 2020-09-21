using System;

namespace B_Attribute
{
    class AttributeTest1
    {
        [Obsolete("disp()method를 사용하지 않습니다. Prn()을 사용합니다.")]
        public void disp()
        {
            Console.WriteLine("disp");
        }
        
        public void Prn()
        {
            Console.WriteLine("Prn");
        }

        public static void Main(string[] args)
        {
           AttributeTest1 at = new AttributeTest1();
           at.disp();
           at.Prn();
        }
    }
}
