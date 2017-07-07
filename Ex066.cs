using System;

//자원 해제 (360p ~ 364p)
namespace Ex066
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileLogger log = new FileLogger("sample.log"))
            {
                log.Write("Start");
                log.Write("End");
            }
        }
    }

    class FileLogger : IDisposable
    {
        FileStream _fs;

        public FileLogger(string fileName)
        {
            _fs = new FileStream(fileName, FileMode.Create);
        }

        public void Write(String txt) { }

        public void Dispose()
        {
            _fs.Close();
        }
    }
}