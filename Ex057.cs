using System;

//예약어(1) (284p ~ 286p)
namespace Ex057
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                short c = 32767;

                unchecked
                {
                    Console.WriteLine(++c);
                }
            }
        }
    }
}