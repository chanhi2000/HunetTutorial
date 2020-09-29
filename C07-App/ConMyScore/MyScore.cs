using System;
using System.Collections.Generic;
using System.Linq;

using ScoreProject;

namespace ConMyScore
{
    class MyScore
    {
        static void Main(string[] args)
        {
            Student[] s = new Student[5];
            s[0] = new MyStudent(1, "김길동", 90, 80, 60, 100);
            s[1] = new MyStudent(2, "홍길동", 77, 100, 74, 70);
            s[2] = new MyStudent(3, "최길동", 100, 100, 91, 86);
            s[3] = new MyStudent(4, "정길동", 93, 90, 37, 90);
            s[4] = new MyStudent(5, "박길동", 57, 95, 25, 90);

            Student.CalcRank(s);
            Console.WriteLine("===========================");
            foreach(Student tmp in s)
            {
                tmp.Calc();
                tmp.Display(5);
            }
            Console.WriteLine("===========================");

            IList<MyStudent> studentList = new List<MyStudent>()
            {
                new MyStudent(1, "김길동", 90, 80, 60, 100),
                new MyStudent(2, "홍길동", 77, 100, 74, 70),
                new MyStudent(3, "최길동", 100, 100, 91, 86),
                new MyStudent(4, "정길동", 93, 90, 37, 90),
                new MyStudent(5, "박길동", 57, 95, 25, 90)
            };

            var newList = studentList.OrderByDescending(x => x.Name).ToList();
            foreach(MyStudent r in newList)
            {
                Console.WriteLine(r.Name);
            }

        }
    }
}
