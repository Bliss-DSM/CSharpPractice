using System;
using System.Collections; //IComparer가 정의된 네임스페이스를 사용

//인터페이스(5) (219p ~ 221p)
namespace Ex028
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };

            //IComparer를 상속받은 IntegerCompare 인스턴스 전달
            Array.Sort(intArray, new IntegerCompare());
            foreach(int item in intArray)
            {
                Console.WriteLine(item + ", ");
            }
        }
    }

    //IComparer를 상속받는 타입 정의
    class IntegerCompare : IComparer
    {
        //IComparer 인터페이스의 Compare 메서드를 구현
        //이 메셔드는 Array.Sort 메서드 내에서 콜백으로 호출됨.
        public int Compare(object x, object y)
        {
            int xValue = (int)x;
            int yValue = (int)y;

            //내림차순 정렬이 되도록 -1을 반환
            if (xValue > yValue) return -1;
            else if (xValue == yValue) return 0;

            return 1;
        }
    }
}