using System;

//열거형(2) (244p ~ 245p)
namespace Ex041
{
    [Flags]
    enum Days
    {
        Sunday = 1, Monday = 2, TuesDay = 4, Wednesday = 8, Thursday = 16, Friday = 32, Saturday = 64
    }

    class Program
    {
        static void Main(string[] args)
        {
            Days workingDays = Days.Monday | Days.TuesDay | Days.Wednesday | Days.Thursday | Days.Friday;

            Console.WriteLine(workingDays.HasFlag(Days.Sunday));

            Days today = Days.Friday;
            Console.WriteLine(workingDays.HasFlag(today));

            Console.WriteLine(workingDays);
        }
    }
}