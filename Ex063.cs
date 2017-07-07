using System;

//재귀 호출(1) (350p)
namespace Ex063
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
        }

        private static long factorial(long n)
        {
            if (n == 0) return 1;

            return n * factorial(n - 1);
        }
    }
}