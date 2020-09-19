using System;

namespace A_Property
{
    public class Student
    {
        public string Name 
        { get; set; } = "홍길돌";
        public static int Counter { get; } = 1;
    }
    public class proc2
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            //s.Name = "홍길동";
            Console.WriteLine("Student Number: {0}", Student.Counter);
            Console.WriteLine("Student Name: {0}", s.Name);
        }
    }
}