using System;

//연산자(1) (280p ~ 281p)
namespace Ex055
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 38;

            int leftShiftResult = n << 2;
            int rightShiftResult = n >> 2;

            Console.WriteLine(leftShiftResult);
            Console.WriteLine(rightShiftResult);
        }
    }
}