using System;
using System.Runtime.InteropServices;

//예약어(3) (287p ~ 289p)
namespace Ex059
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageBeep(0);
        }

        [DllImport("user32.dll")]
        static extern int MessageBeep(uint uType);

        static int TestMethod(uint type)
        {
            return 0;
        }
    }
}