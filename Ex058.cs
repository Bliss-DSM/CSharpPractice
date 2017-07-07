using System;

//예약어(2) (286p ~ 287p)
namespace Ex058
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2, 3, 4, 5));
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            PrintAll(1.05, "Result", 3);
        }

        static int Add(params int[] values)
        {
            int result = 0;

            for(int i = 0; i < values.Length; i++)
            {
                result += values[i];
            }

            return result;
        }

        private static void PrintAll(params object[] values)
        {
            foreach (object value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}