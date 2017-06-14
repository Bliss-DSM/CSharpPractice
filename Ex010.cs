using System;

//base를 이용한 메서드 재사용 (179p)
namespace Ex010
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Computer
    {
        virtual public void Boot()
        {
            Console.WriteLine("메인보드 켜기");
        }
    }

    public class NoteBook : Computer
    {
        public override void Boot()
        {
            //Console.WriteLine("메인보드 켜기");
            base.Boot();
            Console.WriteLine("액정 화면 켜기");
        }
    }
}
