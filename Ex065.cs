using System;

//가비지 수집기 (354p ~ 355p)
namespace Ex065
{
    class Program
    {
        static void Main(string[] args)
        {
            object pg = new object();
            Console.WriteLine(GC.GetGeneration(pg));

            GC.Collect(); //GC 수집을 수행
            Console.WriteLine(GC.GetGeneration(pg));

            GC.Collect(); //GC 수집을 수행
            Console.WriteLine(GC.GetGeneration(pg));

            GC.Collect(); //GC 수집을 수행
            Console.WriteLine(GC.GetGeneration(pg));
        }
    }
}