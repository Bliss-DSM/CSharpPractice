using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

//소멸자(4) (369p ~ 370p)
namespace Ex070
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                UnmanagedMemeoryManager m = new UnmanagedMemeoryManager();
                m = null;

                GC.Collect(); //GC로 인해 소멸자가 호출되므로 비관리 메모리도 해제됨


                //현재 프로세스가 사용하는 메모리 크기 출력
                Console.WriteLine(Process.GetCurrentProcess().PrivateMemorySize64);
            }
        }
    }

    class UnmanagedMemeoryManager : IDisposable
    {
        IntPtr pBuffer;
        bool _disposed;

        public UnmanagedMemeoryManager()
        {
            //AllocCoTaskMem 메서드는 비관리 메모리를 할당한다.
            pBuffer = Marshal.AllocCoTaskMem(4096 * 1024); //의도적으로 4MB 할당
        }

        void Dispose(bool disposing)
        {
            if(_disposed == false)
            {
                Marshal.FreeCoTaskMem(pBuffer);
                _disposed = true;
            }
            
            if(disposing == false)
            {
                //disposing이 false인 경우란 명시적으로 Dispose()를 호출한 경우다.
                //따라서 종료 큐에서 자신을 제거해 GC의 부담을 줄인다.
                GC.SuppressFinalize(this);
            }
        }

        public void Dispose()
        {
            Dispose(false);
        }

        ~UnmanagedMemeoryManager() //소멸자: 가비지 수집이 되면 호출된다.
        {
            Dispose(true);
        }
    }
}