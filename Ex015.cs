using System;

//클래스 간의 형변환 (188p ~ 192p)
namespace Ex015
{
    class Program
    {
        static void Main(string[] args)
        {
            //190p
            Won won = new Won(1000);
            Dollar dollar = new Dollar(1);
            Yen yen = new Yen(13);

            //191p
            yen = new Yen(100);

            Won won1 = yen;
            Won won2 = (Won)yen;

            Console.WriteLine(won1);

            //191p
            dollar = new Dollar(1);

            //won1 = dollar;
            won2 = (Won)dollar;

            Console.WriteLine(won2);
        }
    }

    public class Currency
    {
        decimal money;
        public decimal Money { get { return money; } }

        public Currency(decimal money)
        {
            this.money = money;
        }
    }

    public class Won : Currency
    {
        public Won(decimal money) : base(money) { }

        public override string ToString()
        {
            return Money + "Won";
        }
    }

    public class Dollar : Currency
    {
        public Dollar(decimal money) : base(money) { }

        public override string ToString()
        {
            return Money + "Dollar";
        }

        static public explicit operator Won(Dollar dollar)
        {
            return new Won(dollar.Money * 1000m);
        }
    }

    public class Yen : Currency
    {
        public Yen(decimal money) : base(money) { }

        public override string ToString()
        {
            return Money + "Yen";
        }

        static public implicit operator Won(Yen yen)
        {
            return new Won(yen.Money * 13m);
        }
    }
}