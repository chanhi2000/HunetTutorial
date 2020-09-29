using System;
using System.Collections.Generic;
using System.Linq;

namespace C_QueryOp
{
    public class Test
    {
        public string ID {get; set;}
    }

    public class Test2
    {
        public string Name {get; set;}
        public Test Owner {get; set;}
    }

    public class InnerJoinTest
    {
        public static void Main(string[] args)
        {
            Test t1 = new Test {ID = "aaa"};
            Test t2 = new Test {ID = "bbb"};
            Test t3 = new Test {ID = "ccc"};
            Test t4 = new Test {ID = "ddd"};
            Test t5 = new Test {ID = "eee"};

            Test2 te1 = new Test2 {Name = "111", Owner = t2};
            Test2 te2 = new Test2 {Name = "222", Owner = t2};
            Test2 te3 = new Test2 {Name = "333", Owner = t3};
            Test2 te4 = new Test2 {Name = "444", Owner = t5};
            Test2 te5 = new Test2 {Name = "555", Owner = t1};

            List<Test> t1list = new List<Test> {t1, t2, t3, t4, t5};
            List<Test2> t2list = new List<Test2> {te1, te2, te3, te4, te5};

            var query = from manager in t1list
                join emp in t2list on manager equals emp.Owner
                select new { OwnerName = manager.ID, EmpName = emp.Name};

            foreach(var MandE in query)
            {
                System.Console.WriteLine("\"{0}\" is Manager by {1}", MandE.EmpName, MandE.OwnerName);
            }

        }
    }
}
