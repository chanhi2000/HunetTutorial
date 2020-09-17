using System;

namespace A_WhatIsClass
{
    public class AddList
    {
        private string Addr { get; set; }
        private string Name { get; set; }
        private string Tel { get; set; }

        public string getAddr() 
        {
            return this.Addr;
        }
        public void setAddr(string Addr)
        {
            this.Addr = Addr;
        }

        public string getName()
        {
            return this.Name;
        }
        public void setName(string name)
        {
            this.Name = name;
        }
        public string getTel()
        {
            return this.Tel;
        }
        public void setTel(string Tel)
        {
            this.Tel = Tel;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            AddList s = new AddList();
            s.setName("홍길동");
            s.setAddr("서울");
            s.setTel("77-77");
            Console.WriteLine("{0,10}{1,10}{2,10}", s.getName(), s.getAddr(), s.getTel());
        
            AddList s01 = new AddList();
            s01.setName("정길동");
            s01.setAddr("부산");
            s01.setTel("88-88");
            Console.WriteLine("{0,10}{1,10}{2,10}", s01.getName(), s01.getAddr(), s01.getTel());

            AddList s02 = new AddList();
            s02.setName("성길동");
            s02.setAddr("순천");
            s02.setTel("99-99");
            Console.WriteLine("{0,10}{1,10}{2,10}", s02.getName(), s02.getAddr(), s02.getTel());
            Console.WriteLine("{0,10}{1,10}{2,10}", s.getName(), s.getAddr(), s.getTel());
        }
    }
}