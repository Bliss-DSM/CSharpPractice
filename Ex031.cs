using System;

//인터페이스(8) (225p ~ 226p)
namespace CS_ScriptPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Switch switch1 = new Switch();

            switch1.PowerOn(new Computer());
            switch1.PowerOn(new Monitor());
        }
    }

    interface IPower
    {
        void TurnOn();
    }

    class Computer : IPower
    {
        public void TurnOn()
        {
            Console.WriteLine("Computer: TurnOn");
        }
    }
    
    class Monitor : IPower
    {
        public void TurnOn()
        {
            Console.WriteLine("Monitor: TurnOn");
        }
    }
    class Switch
    {
        public void PowerOn(IPower machine)
        {
            machine.TurnOn();
        }
    }
}