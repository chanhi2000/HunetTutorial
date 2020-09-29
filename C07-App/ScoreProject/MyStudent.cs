using System;

namespace ScoreProject
{
    public class MyStudent : Student
    {
        protected int music { get; set; }
        public override void Calc()
        {
            t_Tot = music;
            for (int i=0; i<3; i++)
            {
                t_Tot += t_Score[i];
            }
            t_Avg = (double) t_Tot/4.0;

            if (t_Avg >= 90)        t_Grade = Grade.A;
            else if (t_Avg >= 80)   t_Grade = Grade.B;
            else if (t_Avg >= 70)   t_Grade = Grade.C;
            else if (t_Avg >= 60)   t_Grade = Grade.D;
            else                    t_Grade = Grade.F;
        }

        public override void Display(int mode)
        {
            DisplayGrade fun = new DisplayGrade(Disp);
            fun += new DisplayGrade(DispMy);
            fun();
        }

        public void DispMy()
        {
            System.Console.WriteLine("{0}   {1}   {2}   {3}  {4}   {5:F}  {6}  {7}", t_Score[0], t_Score[1], t_Score[2], music, t_Tot, t_Avg, t_Rank, t_Grade);
        }

        public MyStudent(int num, string name, int k, int e, int m, int music)
        {
            t_Num = num;
            Name = name;
            t_Score[0] = k;
            t_Score[1] = e;
            t_Score[2] = m;
            this.music = music;
            Calc();
        }

        public static void Main()
        {
            
        }
    }
}