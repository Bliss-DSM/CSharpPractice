using System;

//구조체(4) (233p ~ 236p)
namespace Ex035
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1;

            v1.X = 5;
            v1.Y = 10;

            //메서드 호출 시 ref 예약어 사용
            Change(ref v1);
            Console.WriteLine("v1: X = " + v1.X + ", Y = " + v1.Y);

            Point pt1 = new Point();

            pt1.X = 5;
            pt1.Y = 10;

            //메서드 호출: ref 예약어 사용
            Change(ref pt1);
            Console.WriteLine("pt1: X = " + pt1.X + ", Y = " + pt1.Y);
        }

        //메서드 측에도 해당 매개변수에 ref 예약어를 사용
        static void Change(ref Vector vt)
        {
            vt.X = 7;
            vt.Y = 14;
        }

        //첫 번째 매개변수에 ref 예약어 사용
        private static void Change(ref Point pt)
        {
            pt.X = 7;
            pt.Y = 14;
        }
    }

    struct Vector
    {
        public int X;
        public int Y;
    }

    class Point
    {
        public int X;
        public int Y;
    }
}