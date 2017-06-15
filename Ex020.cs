using System;

//델리게이트(3) (201p ~ 202p)
namespace Ex020
{
    class Program
    {
        delegate void CalcDelegate(int x, int y);

        static void Add(int x, int y) { Console.WriteLine(x + y); }
        static void Subtract(int x, int y) { Console.WriteLine(x - y); }
        static void Multiply(int x, int y) { Console.WriteLine(x * y); }
        static void Divide(int x, int y) { Console.WriteLine(x / y); }

        static void Main(string[] args)
        {
            CalcDelegate calc = Add;
            calc += Subtract;
            calc += Multiply;
            calc += Divide;

            calc(10, 5);

            calc -= Multiply;
            calc(10, 5);
        }
    }
}