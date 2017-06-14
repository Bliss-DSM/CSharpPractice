using System;

//캡슐화, 상속 (141p ~ 173p)
namespace Ex008
{
    class Program
    {
        static void Main(string[] args)
        {
            //142p
            Circle o = new Circle();
            o.Pi = 3.14159;
            double piValue = o.Pi;

            //150p
            Notebook noteBook = new Notebook();
            noteBook.Boot();

            //153p
            Computer pc1 = noteBook;
            pc1.Boot();
            pc1.ShutDown();

            //154p
            Computer pc = new Computer();
            //noteBook = (Notebook)pc;

            Notebook note2 = (Notebook)pc1;
            note2.CloseLid();

            Notebook notebook = new Notebook();
            Desktop desktop = new Desktop();
            NetBook netbook = new NetBook();

            DeviceManager manager = new DeviceManager();
            manager.TurnOff(notebook);
            manager.TurnOff(desktop);
            manager.TurnOff(netbook);

            //155p
            Computer[] machines =
                new Computer[] { new Notebook(), new Desktop(), new NetBook() };

            foreach(Computer device in machines)
            {
                manager.TurnOff(device);
            }

            pc = new Computer();
            notebook = pc as Notebook;
            
            if(notebook != null)
            {
                notebook.CloseLid();
            }

            //156p
            int n = 5;
            
            if(n is string)
            {
                Console.WriteLine("변수 n은 string 타입");
            }

            string txt = "text";
            if(txt is int)
            {
                Console.WriteLine("변수 txt는 int 타입");
            }

            //158p
            Computer computer = new Computer();
            object obj1 = computer;
            Computer pc2 = obj1 as Computer;

            Notebook notebook1 = new Notebook();
            object obj2 = notebook1;
            Notebook pc3 = obj2 as Notebook;

            //159p
            Program program = new Program();
            Console.WriteLine(program.ToString());

            //161p
            Computer computer1 = new Computer();
            Type type = computer.GetType();

            Console.WriteLine(type.FullName);
            Console.WriteLine(type.IsClass);
            Console.WriteLine(type.IsArray);

            int n1 = 5;
            string txt1 = "text";
            Type intType = n1.GetType();

            Console.WriteLine(intType.FullName);
            Console.WriteLine(txt.GetType().FullName);

            Type type1 = typeof(double);
            Console.WriteLine(type1.FullName);

            Console.WriteLine(typeof(System.Int16).FullName);

            //162p
            int n2 = 5;
            int n3 = 5;
            Console.WriteLine(n2.Equals(n3));

            n2 = 6;
            Console.WriteLine(n2.Equals(n3));

            Book book1 = new Book(9788998139018);
            Book book2 = new Book(9788998139018);

            Console.WriteLine(book1.Equals(book2));

            //163p
            string txt2 = new string(new char[] { 't', 'e', 'x', 't' });
            string txt3 = new string(new char[] { 't', 'e', 'x', 't' });

            Console.WriteLine(txt2.Equals(txt3));

            //164p
            short n4 = 256;
            short n5 = 32750;
            short n6 = 256;

            Console.WriteLine(n1.GetHashCode());
            Console.WriteLine(n2.GetHashCode());
            Console.WriteLine(n3.GetHashCode());

            Book book3 = new Book(9788998139018);
            Book book4 = new Book(9788998139018);

            Console.WriteLine(book3.GetHashCode());
            Console.WriteLine(book4.GetHashCode());

            //165p
            int n7 = 256;
            int n8 = 2147483647;

            Console.WriteLine(n7.GetHashCode());
            Console.WriteLine(n8.GetHashCode());

            //166p
            bool[,] boolArray = new bool[,] { { true, false }, { true, false } };
            OutputArrayInfo(boolArray);

            int[] intArray = new int[] { 5, 4, 3, 2, 1, 0 };
            OutputArrayInfo(intArray);

            OutputArrayElements("원본 intArray", intArray);
            Array.Sort(intArray);
            OutputArrayElements("Array.Sort 후 intArray", intArray);

            int[] copyArray = new int[intArray.Length];
            Array.Copy(intArray, copyArray, intArray.Length);

            OutputArrayElements("intArray로부터 복사된 copyArray", copyArray);
        }

        private static void OutputArrayInfo(Array arr)
        {
            Console.WriteLine("배열의 차원 수 : " + arr.Rank);
            Console.WriteLine("배열의 요소 수 : " + arr.Length);
            Console.WriteLine();
        }

        private static void OutputArrayElements(string title, Array arr)
        {
            Console.WriteLine("[" + title + "]");

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr.GetValue(i) + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }

    public class Circle
    {
        private double pi = 3.14;

        public double Pi
        {
            get { return pi; }
            set { pi = value; }
        }
    }

    public class Computer
    {
        protected bool powerOn;
        public void Boot() { }
        public void ShutDown() { }
        public void Reset() { }
    }

    public class Notebook : Computer
    {
        bool fingerScan;
        public bool HasFingerScanDevice() { return fingerScan; }

        public void CloseLid()
        {
            if(powerOn == true)
            {
                ShutDown();
            }
        }
    }

    public class Desktop : Computer
    {

    }

    public class NetBook : Computer
    {

    }

    sealed class Pen
    {

    }

    /*
    public class ElectricPen : Pen
    {

    }
    */
    
    public class DeviceManager
    {
        public void TurnOff(Computer device)
        {
            device.ShutDown();
        }
    }

    class Book
    {
        decimal _isbn;
        public Book(decimal isbn)
        {
            _isbn = isbn;
        }
    }

    class Book1
    {
        string title;
        decimal isbn13;
        string author;

        public Book1(string title) : this(title, 0)
        {

        }

        public Book1(string title, decimal isbn13) : this(title, isbn13, string.Empty)
        {

        }

        public Book1(string title, decimal isbn13, string author)
        {
            this.title = title;
            this.isbn13 = isbn13;
            this.author = author;
        }
    }

    class Book2
    {
        string title;
        static int count;

        public Book2(string title)
        {
            this.title = title;
            this.Open();
            Increment();
        }

        void Open()
        {
            Console.WriteLine(this.title);
            Console.WriteLine(count);
        }

        public void Close()
        {
            Console.WriteLine(this.title + " 책을 덮는다.");
        }

        static void Increment()
        {
            count++;
        }
    }

    public class Computer1
    {
        bool powerOn;
        public void Boot() { }
        public void Shutdown() { }
        public void Reset() { }
    }

    public class NoteBook : Computer1
    {
        bool fingerScan;
        public bool HasFingerScanDevice() { return fingerScan; }
        
        public void CloseLid()
        {
            base.Shutdown();
        }
    }

    class Book3
    {
        decimal isbn13;

        public Book3(decimal isbn13)
        {
            this.isbn13 = isbn13;
        }
    }

    class EBook : Book
    {
        public EBook() : base(0)
        {

        }
        
        public EBook(decimal isbn) : base(isbn)
        {

        }
    }
}