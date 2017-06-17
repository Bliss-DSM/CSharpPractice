using System;

//읽기 전용 필드 (247p ~ 248p)
namespace Ex043
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Scheduler
    {
        readonly int second = 1;
        readonly string name;

        public Scheduler()
        {
            this.name = "일정관리";
        }

        public void Run()
        {
            //this.second = 5;
        }
    }
}