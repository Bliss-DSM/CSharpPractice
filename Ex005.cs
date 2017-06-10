using System;

namespace Ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort u = 65;
            char c = (char)u;
            Console.WriteLine(c);

            int n1 = 40000;
            short s = (short)n1; //overflow
            Console.WriteLine(s);

            string @bool = "true";
            Console.WriteLine(@bool);

            string text1 = null;
            Console.WriteLine(text1);

            const bool result = false;
            const int n2 = 5;
            const string text2 = "Hello";

            //result = true;

            int n3 = Math.Max(0, 5);
            //const int maxN = Math.Max(0, 5);
            const int n4 = 5 * 100 / 2;

            int[] products1 = new int[5];
            string[] names = new string[1000];

            int[] products2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] products3 = new int[] { 1, 2, 3, 4, 5 };

            string text3 = "Hello World";
            char ch1 = text3[0];
            char ch2 = text3[1];

            Console.WriteLine(ch1);
            Console.WriteLine(ch2);

            int[] students = new int[60];
            students[0] = 50;
            Console.WriteLine(students[0]);

            students = new int[120];
            Console.WriteLine(students[0]);

            int[,] arr2 = new int[10, 5];
            short [,,] arr3 = new short[8, 3, 10];

            int[,] arr4 = new int[2, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            int[,,] arr5 = new int[2, 3, 4]
            {
                {
                    { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 },
                    { 9, 10, 11, 12 }
                },
                {
                    { 13, 14, 15, 16 },
                    { 17, 18, 19, 20 },
                    { 21, 22, 23, 24 }
                }
            };

            int[][] arr = new int[5][];
            arr[0] = new int[10];
            arr[1] = new int[9];
            arr[2] = new int[8];
            arr[3] = new int[3];
            arr[4] = new int[5];
        }
    }
}