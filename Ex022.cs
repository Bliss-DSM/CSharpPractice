using System;

//델리게이트(5) (204p ~ 208p)
namespace Ex022
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 5, 2, 3, 1, 0, 4 };

            SortObject so = new SortObject(intArray);
            so.Sort(AscendingCompare);
            so.Display();

            Console.WriteLine();

            so.Sort(DescendingCompare);
            so.Display();
        }

        public static bool AscendingCompare(int arg1, int arg2)
        {
            return (arg1 > arg2);
        }

        public static bool DescendingCompare(int arg1, int arg2)
        {
            return (arg1 < arg2);
        }
    }

    // 배열을 정렬할 수 있는 기능을 가진 타입 정의
    class SortObject
    {
        int[] numbers;

        public delegate bool CompareDelegate(int arg1, int arg2);

        //배열을 생성자의 인자로 받아서 보관
        public SortObject(int[] numbers)
        {
            this.numbers = numbers;
        }

        //전형적인 선택 정렬 알고리즘을 구현한 메서드
        //numbers 배열의 요소를 크기순으로 정렬
        public void Sort(CompareDelegate compareMethod)
        {
            int temp;

            for(int i = 0; i < numbers.Length; i++)
            {
                int lowPos = i;

                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if (compareMethod(numbers[j], numbers[lowPos]))
                    {
                        lowPos = j;
                    }
                }

                temp = numbers[lowPos];
                numbers[lowPos] = numbers[i];
                numbers[i] = temp;
            }
        }

        // numbers 요소를 화면에 출력
        public void Display()
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ",");
            }
        }
    }
}