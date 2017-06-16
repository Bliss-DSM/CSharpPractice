using System;

//인터페이스(4) (218p ~ 220p)
namespace Ex027
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    interface ISource
    {
        //콜백용으로 사용될 메서드를 인터페이스로 분리한다.
        int GetResult();
    }

    class Source : ISource
    {
        public int GetResult() { return 10; }

        public void Test()
        {
            Target target = new Target();
            target.Do(this);
        }
    }

    class Target
    {
        //Source 타입이 아닌 ISource 인터페이스를 받는다.
        public void Do(ISource obj)
        {
            //콜백 메서드 호출
            Console.WriteLine(obj.GetResult());
        }
    }
  }