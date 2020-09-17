using System;

namespace C_MemMgmt
{
    public class Circle3
    {
        public double radius;

        public Circle3() : this(1.0)
        {
        }
        public Circle3(double r)
        {
            this.radius = r;
        }
    }

    public class Construct_Test03
    {
        public static void Main()
        {
            Circle3 circle1 =new Circle3();
            Circle3 circle2 = new Circle3(100.0);

            Console.WriteLine(circle1.radius);
            Console.WriteLine(circle2.radius);
        }
    }
}