using System;

//인터페이스(2) (216p)
namespace Ex025
{
    class Program
    {
        static void Main(string[] args)
        {
            //인터페이스 자체는 new로 인스턴스화할 수  없지만 인터페이스 배열은 가능하다.
            IDrawingObject[] instances = new IDrawingObject[] { new Line(), new Rectangle() };
            
            foreach(IDrawingObject item in instances)
            {
                //인터페이스를 상속받은 개체의 Draw 메서드가 호출됨
                item.Draw();
            }

            //자식 클래스로부터 암시적 형변환 가능
            IDrawingObject instance = new Line();
            instance.Draw();
        }
    }

    interface IDrawingObject
    {
        void Draw();
    }

    class Line : IDrawingObject
    {
        public void Draw() { Console.WriteLine("Line"); }
    }

    class Rectangle : IDrawingObject
    {
        public void Draw() { Console.WriteLine("Rectangle"); }
    }
}