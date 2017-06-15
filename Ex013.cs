using System;

//메서드 오버로드 (184p ~ 185p)
namespace Ex013
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics math = new Mathematics();
            Console.WriteLine(math.Abs(-5));
            Console.WriteLine(math.Abs(-10.052));
            Console.WriteLine(math.Abs(20.01m));
        }
    }

    class Mathematics
    {
        public int Abs(int value)
        {
            return (value >= 0) ? value : -value;
        }

        public double Abs(double value)
        {
            return (value >= 0) ? value : -value;
        }

        public decimal Abs(decimal value)
        {
            return (value >= 0) ? value : -value;
        }
    }
}