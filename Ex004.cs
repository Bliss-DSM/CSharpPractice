using System;

//문자열/불린형 기본 타입 (60p ~ 63p)
namespace Ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = 'A';
            Console.WriteLine(ch1);

            char ch2 = '\u2023';
            Console.WriteLine(ch2);

            string text1 = "Hello World";
            Console.WriteLine(text1);

            string text2 = "\tHello\nWorld";
            Console.WriteLine(text2);

            string text3 = @"\tHello\nWorld";
            Console.WriteLine(text3);

            bool isNumeric = false;
            Console.WriteLine(isNumeric);
        }
    }
}