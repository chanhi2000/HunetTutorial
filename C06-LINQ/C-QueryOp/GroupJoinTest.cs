using System;
using System.Collections.Generic;
using System.Linq;

namespace C_QueryOp
{
    public class GroupJoinTest
    {
        public class Manager
        {
            public string MName {get; set;}
        }
        public class Employee
        {
            public string EName {get; set;}
            public Manager Owner {get; set;}
        }
        public static void Main()
        {
            Manager kim = new Manager {MName = "김길동"};
            Manager Jln = new Manager {MName = "박길동"};
            Manager hong = new Manager {MName = "홍길동"};

            Employee emp = new Employee {EName = "사원", Owner=kim};
            Employee emp1 = new Employee {EName = "사원1", Owner=kim};
            Employee emp2 = new Employee {EName = "사원2", Owner=Jln};
            Employee emp3 = new Employee {EName = "사원3", Owner=null};
            Employee emp4 = new Employee {EName = "사원4", Owner=hong};

            List<Manager> M = new List<Manager> {kim, Jln, hong};
            List<Employee> E = new List<Employee> {emp, emp1, emp2, emp3, emp4};

            var vquery = from E1 in E
                join m1 in M on E1.Owner equals m1 into g
                from subq in g.DefaultIfEmpty()
                select new 
                {
                    OName = E1.EName, 
                    pName = (subq == null ? "상사배치 없음" : subq.MName)
                };

            foreach(var v in vquery)
            {
                System.Console.WriteLine("{0,-15}{1}:", v.OName + ":", v.pName);
            }
        }
    }
}