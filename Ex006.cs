using System;

//제어문 (82p ~ 109p)
namespace Ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 5;
            string result = (value % 2 == 0) ? "짝수" : "홀수";
            Console.WriteLine(result);

            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            foreach(int elem in arr)
            {
                Console.WriteLine(elem);
            }

            int sum = 0;
            int n = 0;

            LOOP:
            n++;

            if (n > 1000)
            {
                goto LOOPEXIT;
            }

            if ((n % 2) != 0) goto LOOP;

            sum += n;
            goto LOOP;

            LOOPEXIT:
            Console.WriteLine(sum);

            bool exitLoop = false;

            for(int x = 2; x < 10; x++)
            {
                for(int y = 1; y < 10; y++)
                {
                    Console.WriteLine(x + " * " + y + " = " + (x * y));

                    exitLoop = ((x == 5) && (y == 8));

                    if(exitLoop == true)
                    {
                        break;
                    }
                }

                if(exitLoop == true)
                {
                    break;
                }
            }

            for(int x = 2; x < 10; x++)
            {
                for(int y = 1; y < 10; y++)
                {
                    Console.WriteLine(x + " * " + y + " = " + (x * y));

                    if ((x == 5) && (y == 8)) goto LOOP_EXIT;
                }
            }

            LOOP_EXIT:;

            //project euler problem 1

            int res = 0;

            for(int i = 1; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0)) res += i;
            }

            Console.WriteLine(res);
        }
    }
}