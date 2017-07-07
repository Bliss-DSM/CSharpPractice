using System;

//예약어(4) (289p ~ 290p)
namespace Ex060
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            unsafe
            {
                GetAddResult(&i, 5, 10);
            }

            Console.WriteLine(i);
        }

        unsafe static void GetAddResult(int* p, int a, int b)
        {
            *p = a + b;
        }
    }
}