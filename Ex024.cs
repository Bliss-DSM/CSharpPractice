using System;

//인터페이스(1) (213p ~ 215p)
namespace Ex024
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    interface IMonitor
    {
        void TurnOn();
        int Inch { get; set; }
        int Width { get; }
    }

    class Notebook : IMonitor
    {
        public void TurnOn() { }

        int inch;
        public int Inch
        {
            get { return inch; }
            set { inch = value; }
        }

        int width;
        public int Width { get { return width; } }
    }
}