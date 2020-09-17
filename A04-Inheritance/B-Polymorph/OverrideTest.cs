using System;

namespace B_Polymorph
{
    
    public class Parent
    {
        public virtual void Prn()
        {
            Console.WriteLine("선조입니다.");
        }
    }
    public class Child1 : Parent
    {
        public override void Prn()
        {
            Console.WriteLine("자손입니다.");
        }
    }
    public class Child2 : Parent
    {
        public new void Prn()
        {
            Console.WriteLine("자손2입니다.");
        }        
    }
    public class OverrideTest
    {
        public static void Main()
        {
            Parent[] s = new Parent[3];
            s[0] = new Parent();
            s[1] = new Child1();
            s[2] = new Child2();

            foreach(Parent c1 in s)
            {
                Console.WriteLine("Car Object: "+c1.GetType());
                c1.Prn();
                Console.WriteLine("----------------");
            }

            // new 를 사용한 메서드는 
            // 파생클래스 메서드가 호출되지 않고
            // 기본 클래스 메서드가 대신 호출 됨 (i.e. Parent.Prn())
        }
    }
}