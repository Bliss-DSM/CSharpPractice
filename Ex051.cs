using System;

//전처리기 지시문(3) (270p)
namespace Ex051;
{
    class Program
    {
        static void Main(string[] args)
        {
#region 확장과 축소 가능
            Console.WriteLine("Helo, World!");
#endregion
        }
    }
}

#line 100 //줄번호 임의 지정 가능
#warning 임의로 경고 발생 가능
#pragma warning disable
#warning pragma로 없앨 warning
#error 임의로 에러 발생 가능