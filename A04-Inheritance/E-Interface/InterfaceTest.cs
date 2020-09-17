using System;

namespace E_Interface
{
    interface ITest
    {
        void Disp(); // 접근지정바 선언하지 않음
        void Prn();
    }

    interface IAAA
    {
        public void kkk();
    }

    class MYClass: ITest, IAAA
    {
        void ITest.Disp()
        {
            Console.WriteLine("disp");
        }
        void ITest.Prn()
        {
            Console.WriteLine("prn");
        }
        public void kkk()
        {
            Console.WriteLine("kkk");
        }
        void IAAA.kkk()
        {
            Console.WriteLine("IAAA.KKK");
        }
    }

    class Class1
    {
        public static void Main()
        {
            MYClass m = new MYClass();
            Console.WriteLine(m.ToString());
            ITest i = new MYClass();
            i.Prn();
            i.Disp();
            m.kkk();
            IAAA a = new MYClass();
            a.kkk();
        }
    }
}
