using System;

namespace A_Property
{
    class Test
    {
        private string Name;
        public string Name1
        {
            get 
            {
                return Name;
            }
            set 
            {
                Name = value;
            }
        }
        
    }
    class pro1
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.Name1 = "홍길동";
            Console.WriteLine("이름은="+t1.Name1);
        }
    }
}
