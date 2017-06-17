using System;

//열거형(1) (242p ~ 244p)
namespace Ex040
{
    enum Days
    {
        Sunday, Monday, TuesDay, Wednesday, Thursday, Friday, Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            Days today = Days.Sunday;
            Console.WriteLine(today);

            int n = (int)today;
            short s = (short)today;

            today = (Days)5;
            Console.WriteLine(today);
        }
    }
}