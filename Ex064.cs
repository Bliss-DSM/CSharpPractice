using System;

//재귀 호출(2) (351p ~ 352p)
namespace Ex064
{
    class Program
    {
        static void Main(string[] args)
        {
            RecursiveCall(1);
        }

        private static void RecursiveCall(long n)
        {
            int i = 5, j = 6, k = 7;

            Console.WriteLine(n);
            RecursiveCall(n + 1);
        }
    }
}