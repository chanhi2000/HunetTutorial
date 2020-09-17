using System;

namespace B_Polymorph
{
    class AA
    {
        public string name;
        public void WriteName()
        {
            Console.WriteLine(name);
        }
    }

    class BB : AA
    {
        public string ability;
        public new void WriteName()
        {
            base.WriteName();
            Console.WriteLine(ability);
        }
        public void Attack()
        {
            WriteName();
            Console.WriteLine(ability);
        }
        public static void Main() 
        {
            BB mobj = new BB();
            mobj.name = "사과";
            mobj.ability = "한국사과 최고!";
            mobj.WriteName();
        }
    }
}
