using System;

//중첩 클래스 (192p ~ 193p)
namespace Ex016
{
    class Program
    {
        static void Main(string[] args)
        {
            //HardDisk.Head head = new HardDisk.Head();
        }
    }

    public class HardDisk
    {
        class Platter
        {

        }

        class Head
        {

        }

        Platter[] platter;
        Head head;
    }
}