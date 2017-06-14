using System;

//object 기본 메서드 확장(1) (180p ~ 181p)
namespace Ex011
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pt = new Point(5, 10);
            Console.WriteLine(pt.ToString());
        }
    }

    public class Point
    {
        int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "X : " + x + ", Y : " + y;
        }
    }
}