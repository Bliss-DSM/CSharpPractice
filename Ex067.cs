using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

//소멸자(1) (364p ~ 365p)
//x86으로 실행할 것
namespace Ex067
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                UnmanagedMemeoryManager m = new UnmanagedMemeoryManager();
                m = null;
                GC.Collect(); //GC를 강제로 수행

                //현재 프로세스가 사용하는 메모리 크기 출력
                Console.WriteLine(Process.GetCurrentProcess().PrivateMemorySize64);
            }
        }
    }

    class UnmanagedMemeoryManager
    {
        IntPtr pBuffer;

        public UnmanagedMemeoryManager()
        {
            //AllocCoTaskMem 메서드는 비관리 메모리를 할당한다.
            pBuffer = Marshal.AllocCoTaskMem(4096 * 1024); //의도적으로 4MB 할당
        }
    }
}