using System;
using System.Collections;

namespace B_ICollection
{
    public class AList
    {
        private string name;
        private int age;
        public AList(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        public override string ToString()
        {
            return string.Format("{0,5},{1,5}", name, age);
        }
    }
    public class QueueTest
    {
        public static void Main(string[] args)
        {
            Queue q = new Queue(5);
            q.Enqueue(new AList("홍길동1", 20));
            q.Enqueue(new AList("홍길동2", 22));
            q.Enqueue(new AList("홍길동3", 23));
            q.Enqueue(new AList("홍길동4", 24));
            q.Enqueue(new AList("홍길동5", 25));
            Prn(q);
        }
        
        private static void Prn(Queue q)
        {
            IEnumerator a = q.GetEnumerator();
            while (a.MoveNext())
            {
                Console.WriteLine("{0,5}", a.Current);
            }
        }
    }

    
}