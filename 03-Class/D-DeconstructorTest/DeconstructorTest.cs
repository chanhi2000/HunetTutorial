using System;

namespace D_DeconstructorTest
{
    class DeconstructorTest
    {
        class AAA : IDisposable
        {
            public AAA()
            {
                Console.WriteLine("생성자 ");
            }

            ~AAA()
            {
                Console.WriteLine("소멸자가 실행됨");
            }

            public void Dispose()
            {
                Console.WriteLine("소멸하는 시점을 만들자 ");
            }
        }

        class BBB
        {
            static void Main(string[] args)
            {   
                using (AAA s = new AAA())
                {
                    Console.WriteLine("소거를 하기를 원하는 시점");
                }
                Console.WriteLine("소거가 되어야만 하는 시점");
                Console.WriteLine("프로그램종료");
                
            }
        }
        
    }
}
