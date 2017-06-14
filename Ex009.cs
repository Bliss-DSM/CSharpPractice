using System;

//메서드 오버라이드 (174p ~ 178p)
namespace Ex009
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal one = new Mammal();
            one.Move();

            Lion lion = new Lion();
            lion.Move();

            Whale whale = new Whale();
            whale.Move();

            Human human = new Human();
            human.Move();

            one = lion;
            one.Move();

            Mammal two = human;
            two.Move();
        }
    }

    class Mammal
    {
        virtual public void Move()
        {
            Console.WriteLine("이동한다.");
        }
    }

    class Lion : Mammal
    {
        override public void Move()
        {
            Console.WriteLine("네 발로 움직인다.");
        }
    }

    class Whale : Mammal
    {
        override public void Move()
        {
            Console.WriteLine("수영한다.");
        }
    }

    class Human : Mammal
    {
       override public void Move()
        {
            Console.WriteLine("두 발로 움직인다.");
        }
    }
}