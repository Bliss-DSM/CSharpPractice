using System;

//예약어(5) (290p ~ 292p)
namespace Ex061
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            Managed inst = new Managed();

            inst.Count = 5;
            inst.Name = "text";

            fixed (int* pValue = &inst.Count)
            {
                *pValue = 6;
            }

            fixed (char* pChar = inst.Name.ToCharArray())
            {
                for (int i = 0; i < inst.Name.Length; i++)
                {
                    Console.WriteLine(*(pChar + i));
                }
            }
        }
    }

    class Managed
    {
        public int Count;
        public string Name;
    }
}