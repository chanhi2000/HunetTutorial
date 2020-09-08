using System;

namespace C_Sealed
{
    class Test 
    {
        public Test()
        {
            Console.WriteLine(" Test ");
        }
    }
    sealed class SealedTest1  : Test
    {
        public int x;
        public int y;
        
    }
    
    public class MainClass
    {
        public static void Main()
        {
            SealedTest1 sc = new SealedTest1();
            sc.x = 110;
            sc.y = 150;
            Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);
        }
    }
}
