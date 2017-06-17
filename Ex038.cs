using System;

//구조체(7) (239p ~ 241p)
namespace Ex038
{
    class Program
    {
        static void Main(string[] args)
        {
            int quotient;

            if(Divide(15, 3, out quotient) == true)
            {
                Console.WriteLine(quotient);
            }
        }

        private static bool Divide(int n1, int n2, out int result)
        {
            if(n2 == 0)
            {
                result = 0;
                return false;
            }

            result = n1 / n2;
            return true;
        }
    }
}