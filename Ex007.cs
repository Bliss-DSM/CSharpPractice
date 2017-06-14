using System;

//클래스 (111p ~ 140p)
namespace Ex007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Person1.CountOfInstance);

            Person1 person1 = new Person1("홍길동");
            Person1 person2 = new Person1("홍길순");

            Console.WriteLine(Person1.CountOfInstance);

            Person2.President.DisplayName();

            //Person2 person3 = new Person2("홍길동");

            Person3.OutputCount();

            Person3 person4 = new Person3("홍길동");
            Person3 person5 = new Person3("홍길동");

            Person3.OutputCount();

            Person5 person6 = new Person5("");
            Console.WriteLine("--------");
            Person5 person7 = new Person5("");
        }
    }

    class Book
    {
        public Book()
        {
            //생성자
        }

        ~Book()
        {
            //소멸자
        }
    }

    class Person1
    {
        static public int CountOfInstance;
        public string _name;

        public Person1(string name)
        {
            CountOfInstance++;
            _name = name;
        }
    }

    class Person2
    {
        static public Person2 President = new Person2("대통령");

        string _name;

        private Person2(string name)
        {
            _name = name;
        }

        public void DisplayName()
        {
            Console.WriteLine(_name);
        }
    }

    class Person3
    {
        static int CountOfInstance;
        public string _name;

        public Person3(string name)
        {
            CountOfInstance++;
            _name = name;
        }

        static public void OutputCount()
        {
            Console.WriteLine(CountOfInstance);
        }
    }

    class Person4
    {
        static public Person4 President;

        public string _name;

        private Person4(string name)
        {
            _name = name;
        }

        static Person4()
        {
            President = new Person4("대통령");
        }
    }

    class Person5
    {
        public string _name;

        public Person5(string name)
        {
            _name = name;
            Console.WriteLine("ctor 실행");
        }

        static Person5()
        {
            Console.WriteLine("cctor 실행");
        }
    }
}