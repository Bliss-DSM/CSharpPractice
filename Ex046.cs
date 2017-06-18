using System;

//이벤트(2) (254p ~ 258p)
namespace Ex046
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeGenerator gen = new PrimeGenerator();

            gen.PrimeGenerated += PrintPrime;   //PrintPrime 콜백 메서드 추가
            gen.PrimeGenerated += SumPrime;     //SumPrime 콜백 메서드 추가

            //1 ~ 10까지 소수를 구하고
            gen.Run(10);
            Console.WriteLine();
            Console.WriteLine(Sum);

            //SumPrime 콜백 메서드를 제거한 후 다시 1 ~ 15까지 소수를 구하는 메서드 호출
            gen.PrimeGenerated -= SumPrime;
            gen.Run(15);
        }

        //콜백으로 등록될 메서드 1
        static void PrintPrime(object sender, EventArgs arg)
        {
            Console.Write((arg as PrimeCallbackArg).Prime + ", ");
        }

        static int Sum;

        //콜백으로 등록될 메서드2
        static void SumPrime(object sender, EventArgs arg)
        {
            Sum += (arg as PrimeCallbackArg).Prime;
        }
    }

    //콜백 값을 담는 클래스 정의
    class PrimeCallbackArg : EventArgs
    {
        public int Prime;

        public PrimeCallbackArg(int prime)
        {
            this.Prime = prime;
        }
    }

    //소수 생성기: 소수가 발생할 때마다 등록된 콜백 메서드를 호출
    class PrimeGenerator
    {
        public event EventHandler PrimeGenerated;

        //주어진 수까지 루프를 돌면서 소수가 발견되면 콜백 메서드 호출
        public void Run(int limit)
        {
            for(int i = 2; i <= limit; i++)
            {
                if(IsPrime(i) == true && PrimeGenerated != null)
                {
                    //콜백을 발생시킨 측의 인스턴스와 발견된 소수를 콜백 메서드에 전달
                    PrimeGenerated(this, new PrimeCallbackArg(i));
                }
            }
        }

        //소수 판정 메서드
        private bool IsPrime(int candidate)
        {
            //홀수가 아니면
            if ((candidate & 1) == 0)
            {
                //2면 true, 아니면 false
                return candidate == 2;
            }

            for(int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0) return false;
            }

            //1이면 false, 아니면 true
            return candidate != 1;
        }
    }
}