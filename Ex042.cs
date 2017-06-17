using System;

//열거형(3) (246p ~ 247p)
namespace Ex042
{
    enum CalcType { Add, Minus, Multiplay, Divide }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calc(CalcType.Add, 5, 6));
        }

        private static int Calc(CalcType opType, int operand1, int operand2)
        {
            switch(opType)
            {
                case CalcType.Add: return operand1 + operand2;
                case CalcType.Minus: return operand1 - operand2;
                case CalcType.Multiplay: return operand1 * operand2;
                case CalcType.Divide: return operand1 / operand2;
            }

            return 0;
        }
    }
}