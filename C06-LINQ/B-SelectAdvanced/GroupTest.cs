using System;
using System.Collections.Generic;
using System.Linq;

namespace B_SelectAdvanced
{
    public class Emp
    {
        public int ID {get; set;}
        public List<int> Sale;
    }

    public class GroupTest
    {
        public static void Main()
        {
            List<Emp> employee = Getemployee();
            var sql = from em in employee group em by em.Sale.Average() > 6000000;

            foreach (var sm in sql)
            {
                System.Console.WriteLine(sm.Key == true ? "괜찮군" : "앙 아닌데");
                foreach(var em in sm)
                {
                    System.Console.WriteLine("    {0}, {1}", em.ID, em.Sale.Average());
                }
            }

            Console.ReadKey();
        }

        public static List<Emp> Getemployee()
        {
            List<Emp> em = new List<Emp> 
            {
                new Emp {ID = 111, Sale = new List<int>{600000000, 700000000, 800000000}},
                new Emp {ID = 112, Sale = new List<int>{870000000, 760000000, 500000000}},
                new Emp {ID = 113, Sale = new List<int>{500000000, 870000000, 780000000}}
            };
            return em;
        }
    }
}