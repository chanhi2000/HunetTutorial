using System;
using System.Collections;

namespace A_IList
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

    public class AList2
    {
        private string name;
        public AList2(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return string.Format("{0,5}", name);
        }
    }

    public class ArrayListTest1
    {
        public static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(new AList("홍길동", 30));
            ar.Add(new AList("정길동", 32));
            ar.Add(new AList("박길동", 40));
            ar.Add(new AList("이길동", 20));
            ar.Add(new AList2("최길동"));
            ar.Add(new AList2("김길동"));
            Prn(ar);
        }

        private static void Prn(ArrayList ar)
        {
            object o = ar;
            foreach(object aa in ar)
            {
                Console.WriteLine(aa);
            }
        }
        
    }
}