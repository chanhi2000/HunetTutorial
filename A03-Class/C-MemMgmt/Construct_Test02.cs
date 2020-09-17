using System;

namespace C_MemMgmt
{
    public class Circle2
    {
        public double radius;
        public Circle2()
        {
            this.radius = 1.0;
        }
        public Circle2(double r)
        {
            this.radius = r;
        }

    }
    public class Construct_Test02
    {
        public static void Main()
        {
            Circle2 c1 = new Circle2();
            Console.WriteLine(c1.radius);

            Circle2 c2 = new Circle2(2.0);
            Console.WriteLine(c2.radius);
        }
    }
}