using System;

namespace D_Abstract
{
    abstract class Test 
    {
        public void Prn()
        {
            Console.WriteLine("Prn");
        }
        public abstract void Prn02(); // 추상 메소드
    }

    class My : Test
    {
        public override void Prn02()
        {
            
        }
    }
    class AbsTest
    {
        static void Main(string[] args)
        {
            // new Test(); // 객체 생성 불가능, 후손의 주손은 대입 받을 수 있다.
            Test t1 = new My();
            
        }
    }
}
