using System;
using System.Collections.Generic;
using System.Linq;


namespace A_SelectBasic
{
    public class FromTest2
    {

        public class Student
        {
            public string Name {get; set;}
            public List<int> Scores {get; set;}

            public static void Main()
            {
                List<Student> students = new List<Student>
                {
                    new Student {Name="김길동", Scores=new List<int> {97, 72, 81, 60}},
                    new Student {Name="나길동", Scores=new List<int> {75, 84, 91, 39}},
                    new Student {Name="동길동", Scores=new List<int> {88, 94, 65, 85}},
                    new Student {Name="라길동", Scores=new List<int> {97, 89, 85, 82}},
                    new Student {Name="마길동", Scores=new List<int> {35, 72, 91, 70}}
                };

                var all = from student in students select student;
                selectAll(all);

                var sq = from student in students 
                    from score in student.Scores
                    where score > 90
                    select new { NIC = student.Name, score };

                Console.WriteLine("scoreQuery:");
                foreach(var student in sq)
                {
                    Console.WriteLine("{0} Score: {1}", student.NIC, student.score);
                }
                Console.WriteLine("Press any key to exit.");
            }

            public static void selectAll(IEnumerable<Student> all)
            {
                Console.WriteLine("\n 전체 출력 ");
                foreach (Student res in all)
                {
                    Console.Write("name : {0} ", res.Name);
                    foreach(int jumsu in res.Scores)
                    {
                        Console.Write("score : {0} ", jumsu);
                    }
                    Console.WriteLine();
                }
            }
        }
        
    }
}