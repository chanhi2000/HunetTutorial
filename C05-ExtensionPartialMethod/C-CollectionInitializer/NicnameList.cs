using System;
using System.Collections;
using System.Collections.Generic;

namespace C_CollectionInitializer
{
    class NicnameList
    {
        public string Name {get; set;}
        List<string> alias = new List<string>();
        public List<string> Alias {get {return alias;}} 
    }

    class Sample
    {
         public string Name {get; set;} 
         public int this[string key]
         {
             get { return 0; }
             set {}
         }
    }

    class CollectionList
    {
        public static void Main(string[] args)
        {
            var s = new Sample
            {
                Name = "sample",
                ["X"] = 1,
                ["Y"] = 2
            };
            Console.WriteLine(s.Name + "," + s["X"].ToString());

            var Nic = new List<NicnameList> 
            {
                new NicnameList{Name="홍장군", Alias={"강아지", "제이미올립", "스누피"}},
                new NicnameList{Name="김장군", Alias={"야옹이", "키티얌"}},
            };

            foreach(var ul in Nic)
            {
                Console.WriteLine("Name: {0:7}", ul.Name);
                foreach(var ar in ul.Alias)
                {
                    Console.Write("{0,7}", ar);
                }
                Console.WriteLine();
            }

        }
    }
}
