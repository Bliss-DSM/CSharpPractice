using System;

//특성(1) (271p ~ 272p)
namespace Ex052
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class AuthorAttribute : System.Attribute { }

    [AuthorAttribute]
    class Dummy1 { }

    //C#에는 Attribute 접미사를 생략해도 된다.
    [Author]
    class Dummy2 { }

    //마치 new Author(); 처럼 생성자를 표현하는 구문도 사용할 수 있다.
    [Author()]
    class Dummy3 { }
}