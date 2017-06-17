using System;

//구조체(1) (227p ~ 229p)
namespace Ex032
{
    class Program
    {
        static void Main(string[] args)
        {
            //v1, v2, v3은 같은 표현
            Vector v1 = new Vector();           //new를 사용해 인스턴스 생성 가능

            Vector v2;                          //new가 없어도 인스턴스 생성 가능
            v2.X = 0;
            v2.Y = 0;

            Vector v3 = new Vector(0, 0);      //명시적으로 생성자 지정 가능

            Console.WriteLine(v3);

            //n1, n2, n3은 같은 표현
            int n1 = new int();

            int n2;
            n2 = 0;

            int n3 = 0;
        }

        struct Vector
        {
            public int X;
            public int Y;

            //매개변수를 가진 생성자 정의
            public Vector(int x, int y)
            {
                //구조체가 가진 모든 필드를 초기화
                this.X = x;
                this.Y = y;
            }

            //System.Object의 ToString을 재정의
            public override string ToString()
            {
                return "X: " + X + ", Y = " + Y;
            }
        }
    }
}