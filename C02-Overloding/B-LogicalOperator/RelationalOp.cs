using System;

namespace B_LogicalOperator
{
    public class Time
    {
        private int hours;
        private int minutes;

        public Time(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.hours += this.minutes/60;
            this.minutes %= 60;
        }

        public static bool operator == (Time t1, Time t2)
        {
            return t1.Equals(t2);
        }
        public static bool operator != (Time t1, Time t2)
        {
            return !(t1.Equals(t2));
        }
        public static bool operator < (Time t1, Time t2)
        {
            return (t1.hours * 60 + t1.minutes) < (t2.hours * 60 + t2.minutes);
        }
        public static bool operator > (Time t1, Time t2)
        {
            return !(t1 < t2);
        }
        public static bool operator <= (Time t1, Time t2)
        {
            return ((t1 < t2) || (t1 == t2));
        }
        public static bool operator >= (Time t1, Time t2)
        {
            return ((t1 > t2) || (t1 == t2));
        }
        public override bool Equals(Object obj)
        {
            Time t1 = (Time) obj;
            return ((this.hours == t1.hours) && (this.minutes == t1.minutes));
        }
        public override int GetHashCode()
        {
            return this.hours*60+this.minutes;
        }
    }

    class Test
    {
        public static void Main(string[] args)
        {
            Time t1 = new Time(1,10);
            Time t2 = t1;
            Time t3 = new Time(2,10);

            System.Console.WriteLine(t3 > t2);
            System.Console.WriteLine(t3 < t2);
            System.Console.WriteLine(t1 == t2);
            System.Console.WriteLine(t1.Equals(t2));
            System.Console.WriteLine(t1 == t3);
            System.Console.WriteLine("GetHashCode = {0}", t1.GetHashCode());

        }
    }
}