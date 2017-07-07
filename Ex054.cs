using System;

//특성(3) (274p ~ 277p)
namespace Ex054
{
    [type: Author("Tester")]
    class Program
    {
        [method: Author("Tester")]
        static void Main(string[] args)
        {

        }
    }
    
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
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