using System;

//델리게이트(4) (203p ~ 204)
namespace Ex021
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    delegate int GetResultDelegate();

    class Target
    {
        public void Do(GetResultDelegate getResult)
        {
            Console.WriteLine(getResult());
        }
    }

    class Source
    {
        public int GetResult()
        {
            return 10;
        }

        public void Test()
        {
            Target target = new Target();
            target.Do(new GetResultDelegate(this.GetResult));
        }
    }
}