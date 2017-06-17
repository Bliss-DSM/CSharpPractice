using System;

//구조체(5) (236p ~ 238p)
namespace Ex036
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = null;

            //메서드 호출: 얕은 복사
            Change1(pt1);
            Console.WriteLine("pt1: " + pt1);

            //메서드 호출: ref 사용
            Change2(ref pt1);
            Console.WriteLine("pt1: X = " + pt1.X + ", Y = " + pt1.Y);
        }

        //얕은 복사
        private static void Change1(Point pt)
        {
            pt = new Point();

            pt.X = 6;
            pt.Y = 12;
        }

        //ref를 이용한 참조에 의한 호출
        private static void Change2(ref Point pt)
        {
            pt = new Point();

            pt.X = 7;
            pt.Y = 14;
        }
    }

    class Point
    {
        public int X;
        public int Y;
    }
}