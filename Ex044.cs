using System;

//상수 (249p ~ 251p)
namespace Ex044
{
    class Program
    {
        const string TEXT = " 변수의 값: ";

        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            Console.WriteLine("x" + TEXT + x);
            Console.WriteLine("y" + TEXT + y);
        }
    }
}