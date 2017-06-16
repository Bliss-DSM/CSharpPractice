using System;
using System.Collections;

//인터페이스(6) (221p ~ 222p)
namespace Ex029
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };

            IEnumerator enumerator = intArray.GetEnumerator();

            //더 이상 열거할 수 없을 때 false를 반환
            while(enumerator.MoveNext())
            {
                Console.Write(enumerator.Current + ", ");
            }

            Console.WriteLine();

            foreach(int elem in intArray)
            {
                Console.Write(elem + ", ");
            }

            Console.WriteLine();

            string name = "Korea";
            foreach(char ch in name)
            {
                Console.Write(ch + ", ");
            }
        }
    }
}