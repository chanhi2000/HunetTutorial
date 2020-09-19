using System;
using static System.Math;

namespace A_Property
{
    abstract public class Draw
    {
        public abstract double Area 
        { get; set; }
    }

	public class Square : Draw
	{
        public double Side;
        public Square(double s)
        {
            Side = s;
        }

        public override double Area
        {
            get 
            {
                return Side * Side;
            }
            set
            {
                Side = Sqrt(value);
            }
        }
	}

    public class Hexa : Draw
    {
        public double Side;
        public Hexa(double s)
        {
            Side = s;
        }
        public override double Area
        {
            get 
            {
                return Side * Side * 6;
            }
            set 
            {
                Side = Sqrt(value / 6);
            }
        }
    }

    public class proc4
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the side: ");
            double side = double.Parse(Console.ReadLine());

            Square sqr = new Square(side);
            Hexa hexa = new Hexa(side);

            System.Console.WriteLine("Area of the Square = {0:F2}", sqr.Area);            
            System.Console.WriteLine("Area of the Hexagon = {0:F2}", hexa.Area);
            System.Console.WriteLine();

            System.Console.WriteLine("Enter the area: ");
            double a = double.Parse(Console.ReadLine());
            sqr.Area = a;
            hexa.Area = a;
            System.Console.WriteLine("Side of the Square = {0:F2}", sqr.Side);            
            System.Console.WriteLine("Side of the Hexagon = {0:F2}", hexa.Side);
            System.Console.WriteLine();

        }
    }

}