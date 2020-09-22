using System;
using System.Collections.Generic;

namespace D_Comparison
{
    public class MyFriends
    {
        public int id;
        public string name;

        public MyFriends(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return string.Format(" {0} : {1}", id, name);
        }
    }

    public class MyFriendsComparer : EqualityComparer<MyFriends>
    {
        public override bool Equals(MyFriends x, MyFriends y)
        {
            if (x==null && y==null) return true;
            else if (x==null || y == null) return false;
            return x.id == y.id;
        }

        public override int GetHashCode(MyFriends obj)
        {
            if (obj==null) throw new ArgumentNullException("obj");
            return obj.id;
        }
    }



    public class CollectionTest3
    {
        public static void Main(string[] args)
        {
            Dictionary<MyFriends, string> dict = new Dictionary<MyFriends, string>(new MyFriendsComparer());
            MyFriends RuO = new MyFriends(2, "RuO");
            MyFriends Dominica = new MyFriends(0, "Dominica");
            MyFriends RuSe = new MyFriends(1, "RuSe");

            dict[RuO] = "RuO@example.net";
            dict[Dominica] = "Dominica@example.net";
            dict[RuSe] = "RuSe@example.net";

            foreach (KeyValuePair<MyFriends, string> pair in dict)
            {
                System.Console.WriteLine("{0,-10} => {1}", pair.Key, pair.Value);
            }
            System.Console.WriteLine();

            MyFriends Ruri = new MyFriends(0, "Ruri");
            System.Console.WriteLine("ContainsKey' {0} ': {1}", Dominica, dict.ContainsKey(Dominica));
            try 
            {
                System.Console.WriteLine("ContainsKey' {0} ': {1}", Ruri, dict.ContainsKey(Ruri));
            }
            catch (Exception e) 
            {

            }
            dict[Ruri] = "http://example.net/~Ruri/";

            foreach (KeyValuePair<MyFriends, string> pair in dict)
            {
                System.Console.WriteLine("{0,-10} => {1}", pair.Key, pair.Value);
            }

        }

        public static void Print(IEnumerable<int> c)
        {
            foreach (int e in c)
            {
                Console.WriteLine(" {0} ",e);
            }
            Console.WriteLine();
        }
    }
}
