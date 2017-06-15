using System;

//델리게이트(1) (196p ~ 198p)
namespace Ex018
{
    class Program
    {
        delegate int FuncDelegate(object arg);

        static void Main(string[] args)
        {
            Disk disk = new Disk();

            FuncDelegate cleanFunc = new FuncDelegate(disk.Clean);
            FuncDelegate workFunc = disk.Clean;

            disk.Clean(null);
            cleanFunc(null);
        }
    }
    
    public class Disk
    {
        public int Clean(object arg)
        {
            Console.WriteLine("작업 실행");
            return 0;
        }
    }
}