#define OUTPUT_LOG

using System;

//전처리기 지시문(1) (266p ~ 269p)
namespace Ex049
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();

            if(string.IsNullOrEmpty(txt) == false)
            {
                Console.WriteLine("사용자 입력: " + txt);
            }
#if OUTPUT_LOG
            else
            {
                Console.WriteLine("입력되지 않음");
            }
#endif
        }
    }
}