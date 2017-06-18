using System;

//인덱서(2) (261p ~ 262p)
namespace Ex048
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook normal = new Notebook(13, 4);

            Console.WriteLine("모니터 인치: " + normal["인치"] + "\"");
            Console.WriteLine("메모리 크기: " + normal["메모리크기"] + "GB");
        }
    }

    class Notebook
    {
        int inch;
        int memoryGB;
        
        public Notebook(int inch, int memoryGB)
        {
            this.inch = inch;
            this.memoryGB = memoryGB;
        }

        //문자열로 인덱스를 지정
        public int this[string propertyName]
        {
            get
            {
                switch(propertyName)
                {
                    case "인치":
                        return inch;

                    case "메모리크기":
                        return memoryGB;
                }

                return -1;
            }
        }
    }
}