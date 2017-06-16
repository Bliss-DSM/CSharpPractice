using System;

//인터페이스(3) (217p ~ 218p)
namespace Ex026
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayObject(new Computer());
            DisplayObject(new Person("홍길동"));
        }

        private static void DisplayObject(object obj)
        {
            //인터페이스로 형변환이 가능한가?
            if (obj is IObjectToString)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }

    //ToString을 재정의한 클래스에만 사용될 빈 인터페이스 정의
    interface IObjectToString { }

    //ToString을 재정의하지 않은 예제 타입
    class Computer { }

    //ToString을 재정의했다는 의미로 인터페이스 상속
    class Person : IObjectToString
    {
        string name;
        
        public Person(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return "Person: " + this.name;
        }
    }
}