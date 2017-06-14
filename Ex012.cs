using System;

//object 기본 메서드 확장(2) (181p ~ 183p)
namespace Ex012
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(9788998139018, "리버스 엔지니어링 바이블", "......");
            Book book2 = new Book(9788998139018, "리버스 엔지니어링 바이블", "......");
            Book book3 = new Book(9788992939409, "파이썬 3.2 프로그래밍", "......");

            Console.WriteLine("book1 == book2 : " + book1.Equals(book2));
            Console.WriteLine("book1 == book3 : " + book1.Equals(book3));
        }
    }

    class Book
    {
        decimal isbn13;
        string title;
        string contents;

        public Book(decimal isbn13, string title, string contents)
        {
            this.isbn13 = isbn13;
            this.title = title;
            this.contents = contents;
        }

        public override int GetHashCode()
        {
            return this.isbn13.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            Book book = obj as Book;
            if (book == null)
            {
                return false;
            }

            return this.isbn13 == book.isbn13;
        }
    }
}