using System;

//특성(2) (272p ~ 274p)
namespace Ex053
{
    //new Author("Anders");와 같은 구문을 연상하면 된다.
    [Author("Anders", Version = 1)]
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class AuthorAttribute : System.Attribute
    {
        string name;

        public AuthorAttribute(string name)
        {
            this.name = name;
        }

        int verson;
        public int Version
        {
            get { return verson; }
            set { verson = value; }
        }
    }
}