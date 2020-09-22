using System;
using System.Collections;

namespace D_Comparison
{
    public class MyFriends: IComparable
    {
        int id;
        string name;

        public MyFriends(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int CompareTo(object obj)
        {
            if (obj ==null) throw new ArgumentNullException();

            MyFriends other = obj as MyFriends;

            if (other == null) throw new ArgumentException();

            if (this.id < other.id)
            {
                return -1; //현제 인스턴스는 인수보다 작을 경우
            }
            else if (this.id > other.id)
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return string.Format(" {0} : {1}", id, name);
        }
    }

    public class CollectionTest
    {
        public static void Main(string[] args)
        {
            MyFriends[] arr = new MyFriends[]{
                new MyFriends(1111, "Eve"),
                new MyFriends(4444, "Dominico"),
                new MyFriends(2222, "Alice"),
                new MyFriends(5555, "RuSe"),
                new MyFriends(3333, "Yhan")
            };

            Console.WriteLine("[before sort]");
            Print(arr);
            Console.WriteLine("[after sort]");
            Array.Sort(arr);
            Print(arr);
        }

        public static void Print(IEnumerable c)
        {
            foreach (MyFriends e in c)
            {
                Console.WriteLine(e);
            }
        }
    }
}
