using System;

namespace A_DeleTest
{
    delegate void Prn();
    // 1. delete Method 원형을 선언;
    class DeleTest 
    {
        public void Disp() 
        {
            Console.WriteLine("disp Method ");
        }
        public void Disp2()
        {
            Console.WriteLine("disp2 Method ");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            // 2. Object 객체로 생성한다.
            DeleTest dt = new DeleTest();
            // 3. 파라미터에게 같은원형의 메소드를 호출
            Prn pr = new Prn(dt.Disp);
            pr(); // 4. 함수처럼 실행
            pr = new Prn(dt.Disp2);
            pr();

        }
    }
}
