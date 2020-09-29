using System;


namespace ScoreProject
{
    public delegate void DisplayGrade();
    public class Student
    {
        public string Name {get; set;}
        public int t_Num, t_Tot;
        public int t_Rank {get; set;}
        protected int[] t_Score = new int[3];

        public double t_Avg;
        protected enum Grade { grd = 1, A, B, C, D, F};
        protected Grade t_Grade;

        public Student() {}

        public Student(int num, string name)
        {
            t_Num = num;
            Name = name;
        }
        public Student(int num, string name, int[] s) : this(num, name, s[0], s[1], s[2])
        {
            
        }        
        public Student(int num, string name, int k, int e, int m)
        {
            t_Num = num;
            Name = name;
            t_Score[0] = k;
            t_Score[1] = e;
            t_Score[2] = m;
            Calc();
        }

        public bool SetScore(int k, int e, int m)
        {
            if (k < 0 || e < 0 || m < 0 || k > 100 || e > 100 || m > 100)
            {
                return false;
            }
            int[] s = {k, e, m};
            SetScore(s);
            return true;
        }

        public void SetScore(int[] s)
        {
            t_Score = s;
            Calc();
        }

        public virtual void Calc()
        {
            for (int i=0; i<3; i++)
            {
                t_Tot += t_Score[i];
            }
            t_Avg = (double) t_Tot / 3.0;
            if (t_Avg >= 95.0)      t_Grade = Grade.grd;
            else if (t_Avg >= 90)   t_Grade = Grade.A;
            else if (t_Avg >= 80)   t_Grade = Grade.B;
            else if (t_Avg >= 70)   t_Grade = Grade.C;
            else if (t_Avg >= 60)   t_Grade = Grade.D;
            else                    t_Grade = Grade.F;
        }


        public static bool operator > (Student s1, Student s2)
        {
            return (s1.t_Tot > s2.t_Tot);
        }


        public static bool operator < (Student s1, Student s2)
        {
            return (s1.t_Tot < s2.t_Tot);
        }


        public override string ToString()
        {
            return Name + " : " + Convert.ToString(t_Rank);
        }


        public int[] Score
        {
            get 
            {
                return t_Score;
            }
        }


        public int Kor
        {
            get
            {
                return t_Score[0];
            }
        }


        public int Eng
        {
            get
            {
                return t_Score[1];
            }
        }


        public int Mat
        {
            get
            {
                return t_Score[2];
            }
        }


        public virtual void Display(int mode)
        {
            DisplayGrade fun = new DisplayGrade(Disp);
            switch(mode)
            {
                case 1:
                    fun += new DisplayGrade(Disp1);
                    break;
                case 2:
                    fun += new DisplayGrade(Disp2);
                    break;
                case 3:
                    fun += new DisplayGrade(Disp3);
                    break;
                case 4:
                    fun += new DisplayGrade(Disp4);
                    break;
                case 5:
                    fun += new DisplayGrade(Disp5);
                    break;
            }
            fun();
        }


        protected void Disp()
        {
            System.Console.Write("{0} {1} ", t_Num, Name);
        }

        protected void Disp1()
        {
            System.Console.WriteLine("{0}  {1}  {2}", t_Score[0], t_Score[1], t_Score[2]);   
        }

        protected void Disp2()
        {
            System.Console.WriteLine("{0} {1:F}", t_Tot, t_Avg);
        }
        
        protected void Disp3()
        {
            System.Console.WriteLine("{0}", t_Grade);
        }

        protected void Disp4()
        {
            System.Console.WriteLine("{0}", t_Rank);
        }

        protected void Disp5()
        {
            System.Console.WriteLine("{0}  {1}  {2}  {3}  {4:F}  {5}  {6}", t_Score[0], t_Score[1], t_Score[2], t_Tot, t_Avg, t_Rank, t_Grade);
        }

        public static void CalcRank(Student[] s)
        {
            int rank = 0;
            for (int i=0; i<s.Length; i++)
            {
                rank = 1;
                for (int j=0; j < s.Length; j++)
                {
                    if (s[i] < s[j]) rank++;
                }
                s[i].t_Rank = rank - 1;
            }
        }
    }
}