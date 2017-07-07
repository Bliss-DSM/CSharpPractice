using System;

//사용자 정의 예외 타입 (341p ~ 342p)
namespace Ex062
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();

            if (txt != "123")
            {
                InvalidPasswordException ex = new InvalidPasswordException("틀린 암호");
                throw ex;
            }

            Console.WriteLine("올바른 암호");
        }
    }

    class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string msg) : base(msg) { }
    }
}