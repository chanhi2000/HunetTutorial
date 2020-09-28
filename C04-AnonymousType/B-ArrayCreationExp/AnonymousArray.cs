using System;

namespace B_ArrayCreationExp
{
    class AnonymousArraay
    {
        public struct A
        {
            public int X { set; get; }
            public int Y { set; get; }
            public int Z { set; get; }
        }

        public static void Main(string[] args)
        {
            A x = new A { X = 0, Y = 1, Z = 2};
            var y  = new {x.X, x.Y};
            System.Console.Write("{0}, {1}\n", y.X, y.Y);

            var array = new[] 
            {
                new {X = 0, Y = 1},
                new {X = 3, Y = -1},
                new {X = 7, Y = 3},
                new {X = 13, Y = -5}
            };

            foreach(var p in array)
            {
                System.Console.Write("{0}\n", p);
            }

            var a = new[] {1, 10, 100, 1000};
            var b = new[] {"hello", null, "world"};
            Prn(a, b);

            var c = new[] 
            {
                new[] {10, 20, 30, 40},
                new[] {50, 60, 70, 80}
            };
            prn2(c);

            var d = new[] 
            {
                new[] {"홍길동", "정길동", "박길동"},
                new[] {"서울", "부산", "인천", "순천", "대구"}
            };
            prn3(d);


            var anonymous = new { X = 1, Y = 2 };
            System.Console.WriteLine(anonymous.X + ":" + anonymous.Y);
            System.Console.WriteLine(anonymous.GetType());
            
        }

        public static void prn3(string[][] d)
        {
            foreach(string[] ar in d)
            {
                foreach(string st in ar)
                {
                    System.Console.Write("{0,5}", st);
                }
                System.Console.WriteLine();
            }
        }


        public static void prn2(int[][] c)
        {
            for (int i=0; i<c.GetLength(0); i++)
            {
                for (int j=0; j<c[0].GetLength(0); j++)
                {
                    System.Console.Write("{0,5}", c[i][j]);
                }
                System.Console.WriteLine();
            }
        }

        public static void Prn(int[] a, string[] b)
        {
            foreach(int i in a)
            {
                System.Console.Write("{0,5}", i);
            }
            System.Console.WriteLine();

            foreach(string bii in b)
            {
                System.Console.Write("{0,5}", bii);
            }
            System.Console.WriteLine();
        }
    }
}
